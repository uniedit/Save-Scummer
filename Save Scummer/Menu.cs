using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Save_Scummer {
    public partial class Menu : Form {

        private static PrivateFontCollection fontCollection = new PrivateFontCollection();

        public Menu() {
            InitializeComponent();
            AllocConsole();
        }

        string currentTime, insidebackup, format;
        string[] files;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool AllocConsole();

        FolderBrowserDialog folder = new FolderBrowserDialog();

        private void btn_Open_Click(object sender, EventArgs e) {
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK) {
                txt_Location.Text = folder.SelectedPath;
            }
        }

        public enum CopyState {
            Ready,
            inProcess,
            Finished
        }

        private CopyState copyStatus = CopyState.Ready;

        public class inTime {
            public static string dateToString {
                get {
                    return DateTime.Now.Ticks.ToString().Substring(5);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            currentTime = inTime.dateToString;

            //format = folder.SelectedPath;
            format = txt_Location.Text;
            if (Directory.Exists(format)) {

                bool form = String.IsNullOrEmpty(format);
                string status;

                if (form == false) {

                    copyStatus = CopyState.inProcess;
                    status = (copyStatus == CopyState.inProcess) ? "Em Processo" : "Erro";
                    Console.WriteLine($"Status: {status}. Copiando arquivos...\n");

                    string sourceFileName = folder.SelectedPath;

                    string exeSource = Assembly.GetExecutingAssembly().Location;
                    string directSource = Path.GetDirectoryName(exeSource);

                    string folderName = "Backup Folder";
                    string newFolderName = Path.Combine(directSource, folderName);

                    if (!Directory.Exists(newFolderName)) {
                        Console.WriteLine($"Pasta de backup não encontrada. Criando...");
                        try {
                            Directory.CreateDirectory(newFolderName);
                        } catch (Exception ex) {
                            MessageBox.Show($"Ocorreu um erro ao criar a pasta: {ex.Message}\n");
                            return;
                        }
                    } else {
                        Console.WriteLine($"Pasta de backup já existe em: {newFolderName}\n");
                    }

                    insidebackup = newFolderName + @"\" + currentTime;
                    Directory.CreateDirectory(insidebackup);

                    string newFolderNameInside = Path.Combine(directSource, folderName);
                    files = Directory.GetFiles(format);

                    foreach (string file in files) {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(insidebackup, fileName);
                        File.Copy(file, destFile, true);
                    }
                    copyStatus = CopyState.Finished;
                    status = (copyStatus == CopyState.Finished) ? "Finalizado" : "Erro";
                    Console.WriteLine($"Status: {status}. Cópia de arquivos concluída!\n");
                    btn_Load.Enabled = true;
                } else {
                    Console.WriteLine("Local não inserido.");
                }
            } else {
                Console.WriteLine("Local não existe no contexto.");
            }
        }

        private void btn_Load_Click(object sender, EventArgs e) {
            files = Directory.GetFiles(insidebackup);
            string destFile = "";
            if (Directory.Exists(format)) {
                if (tbtn_Overwrite.CheckState == CheckState.Checked) {
                    string[] existingFiles = Directory.GetFiles(format);
                    foreach (string file in existingFiles) {
                        File.Delete(file);
                    }
                    foreach (string file in files) {
                        string fileName = Path.GetFileName(file);
                        destFile = Path.Combine(format, fileName);
                        File.Copy(file, destFile, true);
                    }
                    Console.WriteLine($"Copia de arquivos para o Local Raiz Juntamente com Override dos Arquivos concluída!\n");
                } else {
                    foreach (string file in files) {
                        string fileName = Path.GetFileName(file);
                        destFile = Path.Combine(format, fileName);
                        File.Copy(file, destFile, true);
                    }
                    Console.WriteLine($"Copia de arquivos para o Local Raiz concluída!\n");
                }
            } else {
                Console.WriteLine("Local não existe no contexto.");
            }
        }


        private void lstDirectory_SelectedIndexChanged(object sender, EventArgs e) {
            updateDirectory();
        }

        private void txt_Location_TextChanged(object sender, EventArgs e) {
            updateDirectory();
        }

        private void updateDirectory() {
            string basedir = txt_Location.Text;

            if (Directory.Exists(basedir)) {
                lstDirectory.Items.Clear();

                string[] dirs = Directory.GetDirectories(basedir);

                foreach (string dir in dirs) {
                    lstDirectory.Items.Add(Path.GetFileName(dir));
                }

                string[] files = Directory.GetFiles(basedir);

                foreach (string file in files) {
                    lstDirectory.Items.Add(Path.GetFileName(file));
                }
            }
        }

        int i = 0;
        private void txt_Location_MouseClick(object sender, MouseEventArgs e) {
            if (this.txt_Location.Text.Equals("File Location") && i == 0) {
                this.txt_Location.Text = "";
                i = 1;
            }
        }

        private void tbtn_Overwrite_CheckedChanged(object sender, EventArgs e) {

        }

        private void btn_Undo_Click(object sender, EventArgs e) {

        }

        private void lbl_Overwrite_Click(object sender, EventArgs e) {

        }

        private void skeetGroupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
