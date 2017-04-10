using DotNet_Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DotNetProject_AddFolderRefer
{
    public partial class Form1 : Form
    {
        string configFile = "config";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                txtRoot.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                txtDll.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(txtDll.Text))
                {
                    checkedListBox1.Items.Add(txtDll.Text, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            ConfigModel model = null;
            try
            {
                var di = new DirectoryInfo(txtRoot.Text);
                List<string> dllPaths = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    dllPaths.Add(item.ToString());
                }
                if (dllPaths.Count == 0)
                {
                    MessageBox.Show("已选引用路径为空");
                    return;
                }
                var strDllPaths = string.Join(";", dllPaths.ToArray());
                 model = new ConfigModel() { Root = txtRoot.Text, DllPaths = strDllPaths };
                var subFolders = di.GetDirectories();
                foreach (var folder in subFolders)
                {
                    var files = folder.GetFiles("*.csproj");
                    foreach (var file in files)
                    {
                        string path = file.FullName + ".user";//Client
                        XNamespace xn = "http://schemas.microsoft.com/developer/msbuild/2003";
                        //XmlDocument xml = new XmlDocument();
                        XDocument xdoc;
                        if (!File.Exists(path))
                        {  
                            xdoc = new XDocument();
                            var ReferencePath = new XElement(xn + "ReferencePath", strDllPaths);
                            var ProjectView = new XElement(xn + "ProjectView", "ShowAllFiles");
                            var PropertyGroup = new XElement(xn + "PropertyGroup", ReferencePath, ProjectView);
                            //XAttribute
                         
                            var Project = new XElement(xn + "Project", PropertyGroup);
                            //Project.Add(PropertyGroup);

                            //var Project = new XElement("Project", new XAttribute(XNamespace.Xmlns+"x" , xn.NamespaceName), PropertyGroup);

                           
                           // "xmlns"
                            //Project.n(XNamespace.Xmlns, 
                            Project.SetAttributeValue("ToolsVersion", "12.0");
                            //PropertyGroup.RemoveAttributes();
                            //PropertyGroup
                            //SetNamespace(Project, "http://schemas.microsoft.com/developer/msbuild/2003");
                            xdoc.Add(Project);
                            xdoc.Save(path);
                            continue;
                        }

                        {
                            xdoc = XDocument.Load(path);
                            var elements = (xdoc.FirstNode as XElement).Elements();
                            var PropertyGroup1=elements.FirstOrDefault(p => p.Name.LocalName == "PropertyGroup");
                            var Project = xdoc.Element(xn+"Project");
                            var PropertyGroup = Project.Element(xn + "PropertyGroup");
                            //Project.HasElements();
                            var ReferencePath = PropertyGroup.Element(xn + "ReferencePath");
                            if (ReferencePath.Value.Length != 0)
                                strDllPaths = ReferencePath.Value + ";" + strDllPaths;
                            ReferencePath.SetValue(strDllPaths);
                            xdoc.Save(path);
                        }
                    }
                }
                
                MessageBox.Show("处理完成");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Serialize.BinarySerialize(configFile, model);
            }
        }

        public static void SetNamespace(XElement xElement, XNamespace xNamespace)
        {
                // First make sure that the xmlns-attribute is changed
                xElement.SetAttributeValue("xmlns", xNamespace);
                // Then also prefix the name of the element with the namespace
                //xElement.Name = xNamespace + xElement.Name.LocalName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(configFile + ".Binary"))
            {
                var model = Serialize.BinaryDeserialize(configFile) as ConfigModel;
                txtRoot.Text = model.Root;
                checkedListBox1.Items.Clear();
                foreach (var i in model.DllPaths.Split(';'))
                {
                    checkedListBox1.Items.Add(i);
                }
            }
            for (var i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }
    }
}
