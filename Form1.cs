using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace unrailedSaver
{
    public partial class Form1 : Form
    {
        private string gameSavePath = "";
        private string language = "";
        private bool isRestoring = false;
        private static System.IO.FileSystemWatcher m_Watcher;
        public Form1()
        {
            InitializeComponent();

            string[] lines = null;
            try
            {
                lines = File.ReadAllLines(@".\config.txt");
            }
            catch (Exception ex)
            {
                try
                {
                    //StreamWriter sw = new StreamWriter(@".\config.txt", true, Encoding.ASCII);
                    gameSavePath = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + @"\AppData\Local\Daedalic Entertainment GmbH\Unrailed\SaveGames\";
                    //sw.WriteLine(gameSavePath);
                    if (System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName.Equals("pt"))
                    {
                        language = "pt";
                    }
                    else
                    {
                        language = "en";
                    }
                    //sw.Write(language);

                    //sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }

            if (lines != null)
            {
                gameSavePath = lines[0];
                language = lines[1];
            }

            if (language.Equals("pt"))
            {
                comboLanguage.SelectedIndex = 0;
            } else
            {
                comboLanguage.SelectedIndex = 1;
            }

            m_Watcher = new System.IO.FileSystemWatcher();
            m_Watcher.Filter = "*.*";
            m_Watcher.Path = gameSavePath;
            m_Watcher.IncludeSubdirectories = false;
            m_Watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
            m_Watcher.Created += new FileSystemEventHandler(OnChanged);
            m_Watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            try
            {
                if (!isRestoring)
                {
                    System.IO.Directory.CreateDirectory(gameSavePath + @"\bkp");
                    System.IO.File.Copy(e.FullPath, gameSavePath + @"bkp\" + DateTime.Now.ToString("dd-MM-yyyy-H-mm-ss") + ".sav", true);
                }
                else
                {
                    isRestoring = false;
                }
            } catch (Exception err) {}
        }

        private void restoreLastSaveBtn_Click(object sender, EventArgs e)
        {
            isRestoring = true;
            var directory = new DirectoryInfo(gameSavePath + @"bkp\");
            try
            {
                var lastFile = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
                File.Copy(lastFile.FullName, gameSavePath + "slot1.sav", true);
            }
            catch (Exception err)
            {
                MessageBox.Show("No File to Restore.");
            }
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = gameSavePath;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MessageBox.Show(fbd.SelectedPath);
            }
        }

        private void comboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboLanguage.SelectedIndex == 0)
            {
                language = "pt";
                this.changeLanguage("pt");
            } else
            {
                language = "en";
                this.changeLanguage("en");
            }
        }

        private void changeLanguage(string language)
        {
            if (language.Equals("pt"))
            {
                restoreLastSaveBtn.Text = "Restaurar Ultimo Save";
                selectFolderBtn.Text = "Selecionar Pasta do Jogo";
                helpBtn.Text = "Ajuda";
                lblLanguage.Text = "Idioma";
            } else
            {
                restoreLastSaveBtn.Text = "Restore Last Save";
                selectFolderBtn.Text = "Select Game Folder";
                helpBtn.Text = "Help";
                lblLanguage.Text = "Language";
            }
            saveConfigFile();
        }

        private void saveConfigFile()
        {
            StreamWriter sw = new StreamWriter(@".\config.txt", false, Encoding.ASCII);
            sw.WriteLine(gameSavePath);
            sw.Write(language);
            sw.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/filiperangel/unrailed-saver#readme");
        }
    }
}
