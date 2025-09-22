using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.DataFormats;

namespace Save_Scummer {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
            AllocConsole();
        }

        string currentTime, insidebackup, format;
        string[] files;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool AllocConsole();

        private void btn_Undo_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

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

            Console.WriteLine("Isto é um TimeStamp" + currentTime);

            format = folder.SelectedPath;

            bool form = String.IsNullOrEmpty(format);

            if (form == false) {

                copyStatus = CopyState.inProcess;
                Console.WriteLine($"Status: {copyStatus}. Copiando arquivos...");
                Console.WriteLine($"");

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
                        MessageBox.Show($"Ocorreu um erro ao criar a pasta: {ex.Message}");
                        return;
                    }
                } else {
                    Console.WriteLine($"Pasta de backup já existe em: {newFolderName}");
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
                Console.WriteLine($"Status: {copyStatus}. Cópia de arquivos concluída!");
                btn_Load.Enabled = true;
            } else {
                Console.WriteLine("Local não inserido.");
            }

        }

        private void btn_Load_Click(object sender, EventArgs e) {
            files = Directory.GetFiles(insidebackup);
            string destFile = "";
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
            } else {
                foreach (string file in files) {
                    string fileName = Path.GetFileName(file);
                    destFile = Path.Combine(format, fileName);
                    File.Copy(file, destFile, true);
                }
            }
        }

        private void tbtn_Overwrite_CheckedChanged(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
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

        private void lstDirectory_Enter(object sender, EventArgs e) {
            updateDirectory();
        }

        private void lstDirectory_SelectedIndexChanged(object sender, EventArgs e) {
            updateDirectory();
        }

        private void timer1_Tick(object sender, EventArgs e) {
        }
    }
}
