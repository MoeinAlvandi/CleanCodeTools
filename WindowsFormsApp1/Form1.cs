using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        string DefaultFileName = "InitFile.ini";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ProjectRunPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string InitFileFullPath = ProjectRunPath + "\\" + DefaultFileName;


            disableMessages();
            disableCreateBtn();
            ClearAll();


            if (File.Exists(InitFileFullPath))
                LoadFromINI();
            else
                CreateINIFiles();




            EnableCreateBtn();


            if (!string.IsNullOrEmpty(txt_Context.Text) && (!string.IsNullOrEmpty(txt_model.Text)) && (!string.IsNullOrEmpty(txt_id.Text)))
            {
                disableMessages();



                string IRepositoryStr = GenerateIRepositoryString(txt_model.Text, txt_id.Text,chk_paging.Checked);
                txt_IRepositry.Text += IRepositoryStr;





                string RepositoryStr = GenerateRepositoryString(txt_model.Text, txt_Context.Text, chk_RepositoryTryCatch.Checked, txt_repository_Catch_Code.Text,chk_paging.Checked);
                txt_Repository.Text = RepositoryStr;







                txt_IService.Text += GenerateIServiceString(txt_model.Text, txt_id.Text,chk_paging.Checked);






                string ServiceStr = GenerateServiceString(txt_model.Text, chk_ServiceTryCatch.Checked, txt_service_Catch_Code.Text,chk_paging.Checked);
                txt_Service.Text = ServiceStr;


                txt_IOC_Service.Text = "service.AddScoped<I" + txt_model.Text + "Service, " + txt_model.Text + "Service>();";
                txt_IOC_Repository.Text = "service.AddScoped<I" + txt_model.Text + "Repository, " + txt_model.Text + "Repository>();";

                MessageBox.Show("Your Code Is Generate", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }

        private void btn_copy_IRepository_Click(object sender, EventArgs e)
        {
            txt_IRepositry.SelectAll();
            txt_IRepositry.Copy();

            disableMessages();
            lbl_messageIrepository.Text = "IRepository Text Copyed";
            lbl_messageIrepository.Visible = true;

        }

        private void btn_Copy_Repository_Click(object sender, EventArgs e)
        {
            txt_Repository.SelectAll();
            txt_Repository.Copy();

            disableMessages();
            lbl_messageRepository.Text = "Repository Text Copyed";
            lbl_messageRepository.Visible = true;
        }

        private void btn_Copy_IService_Click(object sender, EventArgs e)
        {
            txt_IService.SelectAll();
            txt_IService.Copy();
            disableMessages();
            lbl_messageIService.Text = "IService Text Copyed";
            lbl_messageIService.Visible = true;
        }

        private void btn_Copy_Service_Click(object sender, EventArgs e)
        {
            txt_Service.SelectAll();
            txt_Service.Copy();
            disableMessages();

            lbl_messageService.Text = "Service Text Copyed";
            lbl_messageService.Visible = true;
        }

        private void btn_Create_IRepository_Click(object sender, EventArgs e)
        {
            bool result = WriteIntoFiles("I" + txt_model.Text + "Repository.cs", txt_Irepository_FolderPAth.Text, GenerateIRepositoryString(txt_model.Text, txt_id.Text,chk_paging.Checked));

            disableMessages();
            if (result)
            {
                lbl_messageIrepository.Text = "File Is Create SuccessFully";
            }
            else
            {
                lbl_messageIrepository.Text = "File Is Not Create SuccessFully";
            }



            lbl_messageIrepository.Visible = true;
        }

        private void btn_opendialog_Irepository_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_Irepository.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(fbd_Irepository.SelectedPath);
                txt_Irepository_FolderPAth.Text = fbd_Irepository.SelectedPath;

                var MyIni2 = new IniFile(DefaultFileName);
                MyIni2.Write("IRepositoryFolderPath", fbd_Irepository.SelectedPath, "FilePath");

                disableMessages();
                lbl_messageIrepository.Text = CompactString(txt_Irepository_FolderPAth.Text) + " Is Write Into " + DefaultFileName;
                lbl_messageIrepository.Visible = true;

                EnableCreateBtn();
            }

        }

        private void btn_opendialog_repository_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_repository.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(fbd_Irepository.SelectedPath);
                txt_repository_FolderPAth.Text = fbd_repository.SelectedPath;

                var MyIni2 = new IniFile(DefaultFileName);
                MyIni2.Write("RepositoryFolderPath", fbd_repository.SelectedPath, "FilePath");

                disableMessages();
                lbl_messageRepository.Text = CompactString(txt_repository_FolderPAth.Text) + " Is Write Into " + DefaultFileName;
                lbl_messageRepository.Visible = true;

                EnableCreateBtn();
            }
        }


        private void btn_opendialog_Iservice_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_IService.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(fbd_Irepository.SelectedPath);
                txt_IserviceFolderPath.Text = fbd_IService.SelectedPath;

                var MyIni2 = new IniFile(DefaultFileName);
                MyIni2.Write("IServiceFolderPath", fbd_IService.SelectedPath, "FilePath");


                disableMessages();
                lbl_messageIService.Text = CompactString(txt_IserviceFolderPath.Text) + " Is Write Into " + DefaultFileName;
                lbl_messageIService.Visible = true;

                EnableCreateBtn();
            }
        }

        private void btn_opendialog_service_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_Service.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MessageBox.Show(fbd_Irepository.SelectedPath);
                txt_service_folderpath.Text = fbd_Service.SelectedPath;

                var MyIni2 = new IniFile(DefaultFileName);
                MyIni2.Write("ServiceFolderPath", fbd_Service.SelectedPath, "FilePath");


                disableMessages();
                lbl_messageService.Text = CompactString(txt_service_folderpath.Text) + " Is Write Into " + DefaultFileName;
                lbl_messageService.Visible = true;

                EnableCreateBtn();
            }
        }

        private void lbl_messageRepository_Click(object sender, EventArgs e)
        {

        }





        //public void ddd()
        //{
        //    if (!MyIni.KeyExists("DefaultVolume", "Audio"))
        //    {
        //        MyIni.Write("DefaultVolume", "100", "Audio");
        //    }
        //}


        private void btn_ClearAll_Click(object sender, EventArgs e)
        {

        }





        private void txt_Irepository_FolderPAth_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("IRepositoryFolderPath", txt_Irepository_FolderPAth.Text, "FilePath");


            disableMessages();
            lbl_messageIrepository.Text = CompactString(txt_Irepository_FolderPAth.Text) + " Is Write Into " + DefaultFileName;
            lbl_messageIrepository.Visible = true;
            EnableCreateBtn();
        }

        private void txt_Irepository_FolderPAth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Context_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("Context", txt_Context.Text, "ModelInfo");

        }

        private void txt_model_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("Model", txt_model.Text, "ModelInfo");
        }

        private void btn_LoadINI_Click(object sender, EventArgs e)
        {

        }

        private void btn_CreateAll_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            ClearAll();
            LoadFromINI();
            disableMessages();



            string IRepositoryStr = GenerateIRepositoryString(txt_model.Text, txt_id.Text,chk_paging.Checked);
            txt_IRepositry.Text += IRepositoryStr;





            string RepositoryStr = GenerateRepositoryString(txt_model.Text, txt_Context.Text, chk_RepositoryTryCatch.Checked, txt_repository_Catch_Code.Text,chk_paging.Checked);
            txt_Repository.Text = RepositoryStr;







            txt_IService.Text += GenerateIServiceString(txt_model.Text, txt_id.Text,chk_paging.Checked);






            string ServiceStr = GenerateServiceString(txt_model.Text, chk_ServiceTryCatch.Checked, txt_service_Catch_Code.Text,chk_paging.Checked);
            txt_Service.Text = ServiceStr;


            txt_IOC_Service.Text = "service.AddScoped<I" + txt_model.Text + "Service, " + txt_model.Text + "Service>();";
            txt_IOC_Repository.Text = "service.AddScoped<I" + txt_model.Text + "Repository, " + txt_model.Text + "Repository>();";
            MessageBox.Show("Your Code Is Generate", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            ClearAll();
            disableMessages();
            LoadFromINI();
            MessageBox.Show("Clear!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            LoadFromINI();
        }

        private void btn_deleteINI_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Irepository_FolderPAth.Text))
            {
                bool result = WriteIntoFiles("I" + txt_model.Text + "Repository.cs", txt_Irepository_FolderPAth.Text, GenerateIRepositoryString(txt_model.Text, txt_id.Text,chk_paging.Checked));

            }

            if (!string.IsNullOrEmpty(txt_repository_FolderPAth.Text))
            {
                bool result = WriteIntoFiles(txt_model.Text + "Repository.cs", txt_repository_FolderPAth.Text, GenerateRepositoryString(txt_model.Text, txt_Context.Text, chk_RepositoryTryCatch.Checked, txt_repository_Catch_Code.Text,chk_paging.Checked));

            }

            if (!string.IsNullOrEmpty(txt_IserviceFolderPath.Text))
            {
                bool result = WriteIntoFiles("I" + txt_model.Text + "Service.cs", txt_IserviceFolderPath.Text, GenerateIServiceString(txt_model.Text, txt_id.Text,chk_paging.Checked));

            }

            if (!string.IsNullOrEmpty(txt_service_folderpath.Text))
            {
                bool result = WriteIntoFiles(txt_model.Text + "Service.cs", txt_service_folderpath.Text, GenerateIServiceString(txt_model.Text, txt_id.Text,chk_paging.Checked));

            }


            MessageBox.Show("All Files Create","alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txt_id_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("ModelID", txt_id.Text, "ModelInfo");
        }

        private void txt_repository_FolderPAth_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("RepositoryFolderPath", txt_repository_FolderPAth.Text, "FilePath");


            disableMessages();
            lbl_messageRepository.Text = CompactString(txt_service_folderpath.Text) + " Is Write Into " + DefaultFileName;
            lbl_messageRepository.Visible = true;

            EnableCreateBtn();


        }

        private void txt_IserviceFolderPath_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("IServiceFolderPath", txt_IserviceFolderPath.Text, "FilePath");


            disableMessages();
            lbl_messageIService.Text = CompactString(txt_IserviceFolderPath.Text) + " Is Write Into " + DefaultFileName;
            lbl_messageIService.Visible = true;

            EnableCreateBtn();
        }

        private void btn_opendialog_service_Leave(object sender, EventArgs e)
        {

        }

        private void txt_service_folderpath_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("ServiceFolderPath", txt_service_folderpath.Text, "FilePath");


            disableMessages();
            lbl_messageService.Text = CompactString(txt_service_folderpath.Text) + " Is Write Into " + DefaultFileName;
            lbl_messageService.Visible = true;

            EnableCreateBtn();
        }



        private void chk_RepositoryTryCatch_CheckedChanged(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            if (chk_RepositoryTryCatch.Checked)
            {
                txt_repository_Catch_Code.Enabled = true;



                MyIni2.Write("IsRepositoryTryCatch", "true", "TryCatch");
            }


            else
            {
                txt_repository_Catch_Code.Enabled = false;
                MyIni2.Write("IsRepositoryTryCatch", "false", "TryCatch");
            }

        }

        private void chk_ServiceTryCatch_CheckedChanged(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            if (chk_ServiceTryCatch.Checked)
            {
                txt_service_Catch_Code.Enabled = true;
                MyIni2.Write("IsServiceTryCatch", "true", "TryCatch");
            }

            else
            {
                txt_service_Catch_Code.Enabled = false;
                MyIni2.Write("IsServiceTryCatch", "false", "TryCatch");
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btn_Create_Repository_Click(object sender, EventArgs e)
        {
            bool result = WriteIntoFiles(txt_model.Text + "Repository.cs", txt_repository_FolderPAth.Text, GenerateRepositoryString(txt_model.Text, txt_Context.Text, chk_RepositoryTryCatch.Checked, txt_repository_Catch_Code.Text,chk_paging.Checked));

            disableMessages();
            if (result)
                lbl_messageRepository.Text = "File Is Create SuccessFully";
            else
                lbl_messageRepository.Text = "File Is Not Create SuccessFully";
            lbl_messageRepository.Visible = true;

        }

        private void btn_Create_IService_Click(object sender, EventArgs e)
        {
            bool result = WriteIntoFiles("I" + txt_model.Text + "Service.cs", txt_IserviceFolderPath.Text, GenerateIServiceString(txt_model.Text, txt_id.Text,chk_paging.Checked));

            disableMessages();
            if (result)
                lbl_messageIService.Text = "File Is Create SuccessFully";
            else
                lbl_messageIService.Text = "File Is Not Create SuccessFully";

            lbl_messageIService.Visible = true;
        }

        private void btn_Create_Service_Click(object sender, EventArgs e)
        {
            bool result = WriteIntoFiles(txt_model.Text + "Service.cs", txt_service_folderpath.Text, GenerateServiceString(txt_model.Text, chk_RepositoryTryCatch.Checked, txt_repository_Catch_Code.Text,chk_paging.Checked));

            disableMessages();
            if (result)
                lbl_messageService.Text = "File Is Create SuccessFully";
            else
                lbl_messageService.Text = "File Is Not Create SuccessFully";



            lbl_messageService.Visible = true;
        }


        #region Subs
        public void disableMessages()
        {
            lbl_messageIrepository.Visible = false;
            lbl_messageIService.Visible = false;
            lbl_messageRepository.Visible = false;
            lbl_messageService.Visible = false;
            lbl_Message_IOC.Visible = false;
        }

        public void disableCreateBtn()
        {
            btn_Create_IRepository.Visible = false;
            btn_Create_Repository.Visible = false;
            btn_Create_IService.Visible = false;
            btn_Create_Service.Visible = false;
        }

        public void ClearAll()
        {
            txt_IRepositry.Text = "";
            txt_Repository.Text = "";
            txt_IService.Text = "";
            txt_Service.Text = "";
            txt_IOC_Service.Text = "";
            txt_IOC_Repository.Text = "";

            txt_Context.Text = "";
            txt_model.Text = "";
            txt_id.Text = "";

        }

        public void EnableCreateBtn()
        {
            if (string.IsNullOrEmpty(txt_Irepository_FolderPAth.Text))
                btn_Create_IRepository.Visible = false;
            else
                btn_Create_IRepository.Visible = true;


            if (string.IsNullOrEmpty(txt_repository_FolderPAth.Text))
                btn_Create_Repository.Visible = false;
            else
                btn_Create_Repository.Visible = true;


            if (string.IsNullOrEmpty(txt_IserviceFolderPath.Text))
                btn_Create_IService.Visible = false;
            else
                btn_Create_IService.Visible = true;


            if (string.IsNullOrEmpty(txt_service_folderpath.Text))
                btn_Create_Service.Visible = false;
            else
                btn_Create_Service.Visible = true;


        }


        public string GenerateRepositoryString(string ModelName, string ContextName, bool IsTryCatch, string CatchCode,bool IsPaging)
        {
            string result = "";


            if (IsTryCatch)
            {

                if (string.IsNullOrEmpty(CatchCode))
                {
                    CatchCode = "//Your Code";
                }

                string namespaceProjectname = "";
                if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                    namespaceProjectname = txt_ProjectName.Text + ".";
                string RepositoryStr = "using System;\n"
      + "using System.Collections.Generic;\n"
      + "using System.Linq;\n"
      + "using System.Text;\n\n"
             + "/// <summary>"
       + "/// This Code Generated By Moein Alvandi\n"
       + "/// if You have any question\n"
      + "/// Please ask me from my instagram account\n"
      + "/// @Mr.Programmer2022\n"
      + "/// injoy :D\n"
       + "/// </summary>\n"


      + "namespace" + namespaceProjectname + "Data.Repository\n{\n"
      + "   public class " + ModelName + "Repository";



                RepositoryStr += ": I" + ModelName + "Repository\n{\n" + "private " + ContextName + " " + ContextName.ToLower() + ";\n\n";
                RepositoryStr += "public " + ModelName + "Repository(" + ContextName + " _" + ContextName.ToLower() + ")\n{\n";
                RepositoryStr += ContextName.ToLower() + " = _" + ContextName.ToLower() + ";\n}\n\n";


                #region Delete
                RepositoryStr += "public void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += "            try\n{";



                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Remove(" + ModelName.ToLower() + ");\n";

                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n}\n\n";
                #endregion

                #region GetAll
                RepositoryStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "()\n{\n";
                RepositoryStr += "            try\n{";
                RepositoryStr += "return " + ContextName.ToLower() + "." + ModelName + "s.ToList();\n";
                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n}\n\n";
                #endregion

                if (IsPaging)
                {
                    #region GetAllPaging
                    RepositoryStr += "public IQueryable<" + ModelName + "> GetAll_" + ModelName + "_Paginig(int rowCount, int pageNumber)\n{\n";
                    RepositoryStr += " IQueryable<"+ ModelName + "> result;\n";
                    RepositoryStr += "if (rowCount > 0 && pageNumber > 0)\n";
                    RepositoryStr += "{\n";
                    RepositoryStr += "int take = rowCount;\n";
                    RepositoryStr += "int skip = (pageNumber - 1) * rowCount;\n";
                    RepositoryStr += "result = "+ ContextName.ToLower() + "."+ ModelName + ".Skip(skip).Take(take);\n";
                    RepositoryStr += "}\n";
                    RepositoryStr += "else\n";
                    RepositoryStr += "{\n";
                    RepositoryStr += "result = " + ContextName.ToLower() + "." + ModelName+";\n";
                    RepositoryStr += "}\n";
                    RepositoryStr += "return result; \n}\n\n";

                    #endregion
                }


                #region Get
                RepositoryStr += "public " + ModelName + " Get" + ModelName + "_ByID(int " + txt_id.Text + ")\n{\n";
                RepositoryStr += "            try\n{";
                RepositoryStr += "return " + ContextName.ToLower() + "." + ModelName + "s.Find(" + txt_id.Text + ");\n";
                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n}\n\n";

                #endregion

                #region Insert
                RepositoryStr += "public void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += "            try\n{";
                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Add(" + ModelName.ToLower() + ");\n";
                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n}\n\n";
                #endregion

                #region Update
                RepositoryStr += "public void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += "            try\n{";
                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Update(" + ModelName.ToLower() + ");\n";
                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n}\n\n";
                #endregion

                #region Save
                RepositoryStr += "public void Save" + "()\n{\n";
                RepositoryStr += "            try\n{";
                RepositoryStr += ContextName.ToLower() + ".SaveChanges();\n";
                RepositoryStr += "            }\n            catch (Exception ex)\n            {\n";


                RepositoryStr += "            " + CatchCode + "\n";

                RepositoryStr += "            }\n";
                #endregion

                RepositoryStr += "}\n}\n\n}";

                result = RepositoryStr;
            }
            else
            {
                string namespaceProjectname = "";
                if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                    namespaceProjectname = txt_ProjectName.Text + ".";
                string RepositoryStr = "using System;\n"
       + "using System.Collections.Generic;\n"
       + "using System.Linq;\n"
       + "using System.Text;\n\n"
       + "/// <summary>\n"
       + "/// This Code Generated By Moein Alvandi\n"
       + "/// if You have any question\n"
      + "/// Please ask me from my instagram account\n"
      + "/// @Mr.Programmer2022\n"
      + "/// injoy :D\n"
       + "/// </summary>\n"
       + "namespace " + namespaceProjectname + "Data.Repository\n{\n"
       + "   public class " + ModelName + "Repository";



                RepositoryStr += ": I" + ModelName + "Repository\n{\n" + "private " + ContextName + " " + ContextName.ToLower() + ";\n\n";
                RepositoryStr += "public " + ModelName + "Repository(" + ContextName + " _" + ContextName.ToLower() + ")\n{\n";
                RepositoryStr += ContextName.ToLower() + " = _" + ContextName.ToLower() + ";\n}\n\n";


                #region Delete
                RepositoryStr += "public void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Remove(" + ModelName.ToLower() + ");\n}\n\n";
                #endregion

                #region GetAll
                RepositoryStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "()\n{\n";
                RepositoryStr += "return " + ContextName.ToLower() + "." + ModelName + "s.ToList();\n}\n\n";

                #endregion

                if (IsPaging)
                {
                    #region GetAllPaging
                    RepositoryStr += "public IQueryable<" + ModelName + "> GetAll_" + ModelName + "_Paginig(int rowCount, int pageNumber)\n{\n";
                    RepositoryStr += " IQueryable<" + ModelName + "> result;\n";
                    RepositoryStr += "if (rowCount > 0 && pageNumber > 0)\n";
                    RepositoryStr += "{\n";
                    RepositoryStr += "int take = rowCount;\n";
                    RepositoryStr += "int skip = (pageNumber - 1) * rowCount;\n";
                    RepositoryStr += "result = " + ContextName.ToLower() + "." + ModelName + ".Skip(skip).Take(take);\n";
                    RepositoryStr += "}\n";
                    RepositoryStr += "else\n";
                    RepositoryStr += "{\n";
                    RepositoryStr += "result = " + ContextName.ToLower() + "." + ModelName + ";\n";
                    RepositoryStr += "}\n";
                    RepositoryStr += "return result; \n}\n\n";

                    #endregion
                }

                #region Get
                RepositoryStr += "public " + ModelName + " Get" + ModelName + "_ByID(int " + txt_id.Text + ")\n{\n";
                RepositoryStr += "return " + ContextName.ToLower() + "." + ModelName + "s.Find(" + txt_id.Text + ");\n}\n\n";

                #endregion

                #region Insert
                RepositoryStr += "public void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Add(" + ModelName.ToLower() + ");\n}\n\n";

                #endregion

                #region Update
                RepositoryStr += "public void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                RepositoryStr += ContextName.ToLower() + "." + ModelName + "s.Update(" + ModelName.ToLower() + ");\n}\n\n";

                #endregion

                #region Save
                RepositoryStr += "public void Save" + "()\n{\n";
                RepositoryStr += ContextName.ToLower() + ".SaveChanges();\n}\n\n";

                #endregion

                RepositoryStr += "}\n}";
                result = RepositoryStr;
            }
            return result;
        }



        public string GenerateServiceString(string ModelName, bool IsTryCatch, string CatchCode,bool IsPaging)
        {
            string result = "";
            if (IsTryCatch)
            {

                if (string.IsNullOrEmpty(CatchCode))
                {
                    CatchCode = "//Your Code";
                }
                string namespaceProjectname = "";
                if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                    namespaceProjectname = txt_ProjectName.Text + ".";

                string ServiceStr = "using System;\n"
+ "using System.Collections.Generic;\n"
+ "using System.Linq;\n"
+ "using System.Text;\n\n"
+ "/// <summary>"
+ "/// This Code Generated By Moein Alvandi\n"
+ "/// if You have any question\n"
+ "/// Please ask me from my instagram account\n"
+ "/// @Mr.Programmer2022\n"
+ "/// injoy :D\n"
+ "/// </summary>\n"
+ "namespace " + namespaceProjectname + "Core.Service\n{\n"
+ "   public class " + ModelName + "Service";



                ServiceStr += ": I" + ModelName + "Service\n{\n" + "private I" + ModelName + "Repository " + ModelName.ToLower() + "Repository;\n\n";
                ServiceStr += "public " + ModelName + "Service(I" + ModelName + "Repository _" + ModelName.ToLower() + "Repository)\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository = _" + ModelName.ToLower() + "Repository;\n}\n\n";


                #region Delete
                ServiceStr += "public void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += ModelName.ToLower() + "Repository." + "Delete" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";


                #endregion
                #region Insert
                ServiceStr += "public void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += ModelName.ToLower() + "Repository." + "Insert" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";


                #endregion

                #region Update
                ServiceStr += "public void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += ModelName.ToLower() + "Repository." + "Update" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";

                #endregion
                #region GetAll
                ServiceStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "()\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += "return " + ModelName.ToLower() + "Repository.GetAll_" + ModelName + "();\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";
                #endregion
                if (IsPaging)
                {
                    #region GetAllPaging
                    ServiceStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "_Paging(int rowCount, int pageNumber)\n{\n";
                    ServiceStr += "List<" + ModelName + "> " + "result = " + ModelName.ToLower() + "Repository.GetAll_" + ModelName + "_Paging(rowCount,pageNumber).ToList();\n";
                    ServiceStr += "return result;\n}\n\n";

                    #endregion
                }
                #region Get
                ServiceStr += "public " + ModelName + " Get" + ModelName + "_ByID(int " + txt_id.Text + ")\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += "return " + ModelName.ToLower() + "Repository.Get" + ModelName + "_ByID(" + txt_id.Text + ");\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";
                #endregion



                #region Save
                ServiceStr += "public void Save" + "()\n{\n";
                ServiceStr += "            try\n{";
                ServiceStr += ModelName.ToLower() + "Repository.Save();\n";
                ServiceStr += "            }\n            catch (Exception ex)\n            {\n";


                ServiceStr += "            " + CatchCode + "\n";

                ServiceStr += "            }\n}\n\n";

                #endregion

                ServiceStr += "}\n}";

                result = ServiceStr;


            }
            else
            {
                string namespaceProjectname = "";
                if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                    namespaceProjectname = txt_ProjectName.Text + ".";


                string ServiceStr = "using System;\n"
+ "using System.Collections.Generic;\n"
+ "using System.Linq;\n"
+ "using System.Text;\n\n"
+ "/// <summary>"
+ "/// This Code Generated By Moein Alvandi\n"
+ "/// if You have any question\n"
+ "/// Please ask me from my instagram account\n"
+ "/// @Mr.Programmer2022\n"
+ "/// injoy :D\n"
+ "/// </summary>\n"
+ "namespace " + namespaceProjectname + "Core.Service\n{\n"
+ "   public class " + ModelName + "Service";



                ServiceStr += ": I" + ModelName + "Service\n{\n" + "private I" + ModelName + "Repository " + ModelName.ToLower() + "Repository;\n\n";
                ServiceStr += "public " + ModelName + "Service(I" + ModelName + "Repository _" + ModelName.ToLower() + "Repository)\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository = _" + ModelName.ToLower() + "Repository;\n}\n\n";


                #region Delete
                ServiceStr += "public void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository." + "Delete" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();}\n\n";


                #endregion
                #region Insert
                ServiceStr += "public void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository." + "Insert" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();}\n\n";


                #endregion

                #region Update
                ServiceStr += "public void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ")\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository." + "Update" + ModelName + "(" + ModelName.ToLower() + ");\n";
                ServiceStr += "Save();}\n\n";
                #endregion
                #region GetAll
                ServiceStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "()\n{\n";
                ServiceStr += "return " + ModelName.ToLower() + "Repository.GetAll_" + ModelName + "();\n}\n\n";

                #endregion

                if(IsPaging)
                {
                    #region GetAllPaging
                    ServiceStr += "public List<" + ModelName + "> " + " GetAll_" + ModelName + "_Paging(int rowCount, int pageNumber)\n{\n";
                    ServiceStr += "List<" + ModelName + "> " + "result = " + ModelName.ToLower() + "Repository.GetAll_" + ModelName + "_Paging(rowCount,pageNumber).ToList();\n";
                    ServiceStr += "return result;\n}\n\n";

                    #endregion
                }

                #region Get
                ServiceStr += "public " + ModelName + " Get" + ModelName + "_ByID(int " + txt_id.Text + ")\n{\n";
                ServiceStr += "return " + ModelName.ToLower() + "Repository.Get" + ModelName + "_ByID(" + txt_id.Text + ");\n}\n\n";

                #endregion



                #region Save
                ServiceStr += "public void Save" + "()\n{\n";
                ServiceStr += ModelName.ToLower() + "Repository.Save();\n}\n\n";

                #endregion

                ServiceStr += "}\n}";

                result = ServiceStr;
            }


            return result;
        }

        public string GenerateIRepositoryString(string ModelName, string IDName,bool IsPaging)
        {
            string result = "";

            string namespaceProjectname = "";
            if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                namespaceProjectname = txt_ProjectName.Text + ".";
            string IRepositoryStr = "using System;\n"
+ "using System.Collections.Generic;\n"
+ "using System.Linq;\n"
+ "using System.Text;\n\n"
+ "/// <summary>"
+ "/// This Code Generated By Moein Alvandi\n"
+ "/// if You have any question\n"
+ "/// Please ask me from my instagram account\n"
+ "/// @Mr.Programmer2022\n"
+ "/// injoy :D\n"
+ "/// </summary>\n"
+ "namespace " + namespaceProjectname + "Domain.Interface\n{\n"
+ "   public interface I" + ModelName + "Repository\n{\n";



            IRepositoryStr += ModelName + " Get" + ModelName + "_ByID(int " + IDName + ");\n";

            IRepositoryStr += "List<" + ModelName + "> GetAll_" + ModelName + "();\n";
            if(IsPaging)
                IRepositoryStr += "IQueryable<" + ModelName + "> GetAll_" + ModelName + "_Paginig(int rowCount, int pageNumber);\n";
            IRepositoryStr += "void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IRepositoryStr += "void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IRepositoryStr += "void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IRepositoryStr += "void Save();\n}\n}";


            result = IRepositoryStr;
            return result;
        }

        public string GenerateIServiceString(string ModelName, string IDName,bool IsPaging)
        {
            string result = "";

            string namespaceProjectname = "";
            if (!string.IsNullOrEmpty(txt_ProjectName.Text))
                namespaceProjectname = txt_ProjectName.Text + ".";

            string IServiceStr = "using System;\n"
+ "using System.Collections.Generic;\n"
+ "using System.Linq;\n"
+ "using System.Text;\n\n"
+ "/// <summary>"
+ "/// This Code Generated By Moein Alvandi\n"
+ "/// if You have any question\n"
+ "/// Please ask me from my instagram account\n"
+ "/// @Mr.Programmer2022\n"
+ "/// injoy :D\n"
+ "/// </summary>\n"
+ "namespace " + namespaceProjectname + "Core.Interface\n{\n"
+ "   public interface I" + ModelName + "Service\n{\n";



            IServiceStr += ModelName + " Get" + ModelName + "_ByID(int " + IDName + ");\n";

            IServiceStr += "List<" + ModelName + "> GetAll_" + ModelName + "();\n";


            IServiceStr += "List<" + ModelName + "> GetAll_" + ModelName + "_Paging(int rowCount, int pageNumber);\n";


            IServiceStr += "void Insert" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IServiceStr += "void Update" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IServiceStr += "void Delete" + ModelName + "(" + ModelName + " " + ModelName.ToLower() + ");\n";
            IServiceStr += "void Save();\n}\n}";


            result = IServiceStr;
            return result;
        }


        public bool WriteIntoFiles(string fileName, string folderPath, string Source)
        {
            try
            {

                string FullPath = @folderPath + "\\" + fileName;
                using (StreamWriter sw = new StreamWriter(FullPath))
                {
                    sw.WriteLine(Source);
                }
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;

            }


        }

        public string CompactString(string InputeValue)
        {
            string result = "";
            if (!string.IsNullOrEmpty(InputeValue))
            {
                if (InputeValue.Length > 15)
                {
                    string tmp = InputeValue.Replace("\\\\", "\\");
                    string[] splittext = tmp.Split('\\');


                    result = InputeValue.Substring(0, 15) + "...\\" + splittext.LastOrDefault();

                }
            }
            return result;
        }


        public void CreateINIFiles()
        {
            var MyIni2 = new IniFile(DefaultFileName);

            MyIni2.Write("IRepositoryFolderPath", "", "FilePath");
            MyIni2.Write("RepositoryFolderPath", "", "FilePath");
            MyIni2.Write("IServiceFolderPath", "", "FilePath");
            MyIni2.Write("ServiceFolderPath", "", "FilePath");

            MyIni2.Write("ProjectName", "", "ModelInfo");
            MyIni2.Write("Context", "", "ModelInfo");
            MyIni2.Write("Model", "", "ModelInfo");
            MyIni2.Write("ModelID", "", "ModelInfo");

            MyIni2.Write("IsRepositoryTryCatch", "false", "TryCatch");
            MyIni2.Write("IsServiceTryCatch", "false", "TryCatch");

            MyIni2.Write("IsPaging", "false", "Paging");

        }



        public void LoadFromINI()
        {
            var MyIni2 = new IniFile(DefaultFileName);


            txt_Irepository_FolderPAth.Text = MyIni2.Read("IRepositoryFolderPath", "FilePath");
            txt_repository_FolderPAth.Text = MyIni2.Read("RepositoryFolderPath", "FilePath");
            txt_IserviceFolderPath.Text = MyIni2.Read("IServiceFolderPath", "FilePath");
            txt_service_folderpath.Text = MyIni2.Read("ServiceFolderPath", "FilePath");

            txt_Context.Text = MyIni2.Read("Context", "ModelInfo");
            txt_ProjectName.Text = MyIni2.Read("ProjectName", "ModelInfo");
            txt_model.Text = MyIni2.Read("Model", "ModelInfo");
            txt_id.Text = MyIni2.Read("ModelID", "ModelInfo");



            if (MyIni2.Read("IsRepositoryTryCatch", "TryCatch").Equals("false"))
            {
                chk_RepositoryTryCatch.Checked = false;
            }
            else if (MyIni2.Read("IsRepositoryTryCatch", "TryCatch").Equals("true"))
            {
                chk_RepositoryTryCatch.Checked = true;
            }




            if (MyIni2.Read("IsServiceTryCatch", "TryCatch").Equals("false"))
            {
                chk_ServiceTryCatch.Checked = false;
            }
            else if (MyIni2.Read("IsServiceTryCatch", "TryCatch").Equals("true"))
            {
                chk_ServiceTryCatch.Checked = true;
            }


            if (MyIni2.Read("IsPaging", "Paging").Equals("false"))
            {
                chk_paging.Checked = false;
            }
            else if (MyIni2.Read("IsPaging", "Paging").Equals("true"))
            {
                chk_paging.Checked = true;
            }
            //var HomePage = MyIni2.Read("HomePage");
        }

        #endregion

        private void btn_Copy_IOCService_Click(object sender, EventArgs e)
        {
            txt_IOC_Service.SelectAll();
            txt_IOC_Service.Copy();


            disableMessages();
            lbl_Message_IOC.Text =  "IOC.Service Text Copyed";
            lbl_Message_IOC.Visible = true;
        }

        private void txt_IOC_Repository_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Copy_IOCRepository_Click(object sender, EventArgs e)
        {
            txt_IOC_Repository.SelectAll();
            txt_IOC_Repository.Copy();


            disableMessages();
            lbl_Message_IOC.Text = "IOC.Repository Text Copyed";
            lbl_Message_IOC.Visible = true;
        }

        private void txt_ProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Context_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ProjectName_Leave(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            MyIni2.Write("ProjectName", txt_ProjectName.Text, "ModelInfo");
        }

        private void chk_paging_CheckedChanged(object sender, EventArgs e)
        {
            var MyIni2 = new IniFile(DefaultFileName);
            if (chk_paging.Checked)
            {
                  MyIni2.Write("IsPaging", "true", "Paging");
            }


            else
            {

                MyIni2.Write("IsPaging", "false", "Paging");
            }
        }
    }
}
