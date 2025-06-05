using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DesktopMessageApp1
{
    public partial class Form1 : Form
    {
        public string CurrentTab { get; set; }
        public string RootDir { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInbox();
            GetRootDirectory();
        }

        private void LoadInbox()
        {
            CurrentTab = "R";
            string sql = "";

            if (rbSMS.Checked)
            {
                sql = "Select * from Messages Where Status = '" + CurrentTab + "' And MMS = 0";

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);

                clbMsgIn.Items.Clear();
                clbMsgIn.DisplayMember = "Text";
                clbMsgIn.ValueMember = "Value";

                if (smsInfo.Count > 0)
                {
                    foreach (var sms in smsInfo)
                    {
                        clbMsgIn.Items.Add(new ListBoxItem { Text = sms.Recipient + ": " + sms.Text, Value = sms.ID.ToString() });
                    }
                }
            }
            else
            {
                sql = "Select * from Messages Where Status = '" + CurrentTab + "' And MMS = 1";

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);

                clbMsgIn.Items.Clear();
                clbMsgIn.DisplayMember = "Text";
                clbMsgIn.ValueMember = "Value";

                if (mmsInfo.Count > 0)
                {
                    foreach (var mms in mmsInfo)
                    {
                        clbMsgIn.Items.Add(new ListBoxItem { Text = mms.Recipient + ": " + mms.Text, Value = mms.ID.ToString() });
                    }
                }
            }
        }
        private void LoadOutbox()
        {
            CurrentTab = "S";
            string sql = "";

            if (rbSMS.Checked)
            {
                sql = "Select * from Messages Where Status = '" + CurrentTab + "' And MMS = 0";

                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);

                cblMsgOut.Items.Clear();
                cblMsgOut.DisplayMember = "Text";
                cblMsgOut.ValueMember = "Value";

                if (smsInfo.Count > 0)
                {
                    foreach (var sms in smsInfo)
                    {
                        cblMsgOut.Items.Add(new ListBoxItem { Text = sms.Recipient + ": " + sms.Text, Value = sms.ID.ToString() });
                    }
                }
            }
            else
            {
                sql = "Select * from Messages Where Status = '" + CurrentTab + "' And MMS = 1";

                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);

                cblMsgOut.Items.Clear();
                cblMsgOut.DisplayMember = "Text";
                cblMsgOut.ValueMember = "Value";

                if (mmsInfo.Count > 0)
                {
                    foreach (var mms in mmsInfo)
                    {
                        cblMsgOut.Items.Add(new ListBoxItem { Text = mms.Recipient + ": " + mms.Text, Value = mms.ID.ToString() });
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBoxes();
        }

        private void MessageRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            ClearMesageFields();

            if (rbSMS.Checked)
            {
                HideAllMediaComponents();
            }
            else
                ShowInitalMediaComponents();

            LoadListBoxes();
        }


        private void LoadSelectMessage()
        {
            string id = "";
            string recipient = "";
            string text = "";
            int mediatype = 0;
            string fname = "";

            id = GetSelectedID();

            string sql = "Select * From Messages Where ID = '" + id + "'";

            if (rbSMS.Checked)
            {
                //Gives back a list of info, could potentially be a list of messages
                var smsInfo = Data.GetData<SMS>(sql, CommandType.Text);
                SMS s = new SMS();

                //We are vreating this to make sure we get the fist outcome just in case.
                if (smsInfo.Count > 0)
                {
                    var sms = smsInfo[0];

                    s.ID = sms.ID;
                    s.Sender = lblSender.Text;
                    s.Recipient = sms.Recipient;
                    s.Text = sms.Text;
                    s.Status = sms.Status;
                    s.IsGroupMessage = sms.IsGroupMessage;
                    s.MMS = sms.MMS;
                }

                recipient = s.Recipient;
                text = s.Text;

                if (s.IsGroupMessage)
                    cbxGroup.Checked = true;
                else
                    cbxGroup.Checked = false;   

            }
            else
            {
                var mmsInfo = Data.GetData<MMS>(sql, CommandType.Text);
                MMS m = new MMS();

                if (mmsInfo.Count > 0)
                {
                    var mms = mmsInfo[0];

                    m.ID = mms.ID;
                    m.Sender = lblSender.Text;
                    m.Recipient = mms.Recipient;
                    m.Text = mms.Text;
                    m.Status = mms.Status;
                    m.IsGroupMessage = mms.IsGroupMessage;
                    m.MMS = mms.MMS;
                    m.Picture = mms.Picture;
                    m.Audio = mms.Audio;
                    m.Video = mms.Video;
                    m.FileName = mms.FileName;
                }

                recipient = m.Recipient;
                text = m.Text;
                fname = m.FileName;

                if (m.IsGroupMessage)
                    cbxGroup.Checked = true;
                else
                    cbxGroup.Checked = false;

                if (m.Picture)
                    mediatype = 1;
                else if (m.Audio)
                    mediatype = 2;
                else if (m.Video)
                    mediatype = 3;
                else
                    mediatype = 0;

            }

            txtRecipient.Text = recipient;
            txtText.Text = text;
            if (mediatype == 1)
            {
                rbPic.Checked = true;
                txtFile.Text = fname;
                LoadPicture();
            }
            else if (mediatype == 2)
            {
                rbAudio.Checked = true;
                txtFile.Text = fname;
            }
            else if (mediatype == 3)
            {
                rbVid.Checked = true;
                txtFile.Text = fname;
            }
            else
            {
                rbPic.Checked = true;
                txtFile.Text = "";
            }

            if (id.Length > 0)
            {
                DisableMessageComponents();
                DisableMediaComponents();
            }
            else
            {
                EnableMessgaeComponents();

                if (rbMMS.Checked)
                {
                    EnableMediaComponents();
                    ShowPicComponents();
                }
            }


        }

        private void LoadListBoxes()
        {
            if (tabControl1.SelectedIndex == 0)
                LoadInbox();
            else
                LoadOutbox();
        }

        private void LoadPicture()
        {
            if (!pictureBox1.Visible)
                pictureBox1.Visible = true;

            string filePath = RootDir + "Images\\" + txtFile.Text;

            // Create a new bitmap object from the picture file at the location provided,
            // and assign it to the pictureBox1.Image property
            pictureBox1.Image = new Bitmap(filePath);

        }


        private string GetSelectedID()
        {
            string id = "";

            if (CurrentTab == "R")
            {
                foreach (var itemChecked in clbMsgIn.CheckedItems)
                {
                    var msg = (ListBoxItem)itemChecked;
                    id = msg.Value;
                }
            }
            else
            {
                foreach (var itemChecked in cblMsgOut.CheckedItems)
                {
                    var msg = (ListBoxItem)itemChecked;
                    id = msg.Value;
                }
            }

            return id;
        }


        private void Message_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectMessage();

        }


        private void MessageListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox items = (CheckedListBox)sender;

            if (items.CheckedItems.Count >= 1)
                e.NewValue = CheckState.Unchecked;
        }


        private void HideMediaComponents()
        {
            pictureBox1.Image = null;
            pictureBox1.Visible = false;

            MediaPlayer.Visible = false;
            lblFile.Visible = false;

            btnFile.Visible = false;
            txtFile.Text = "";
            txtFile.Visible = false;
            btnPlay.Visible = false;
            btnStop.Visible = false;
            btnShow.Visible = false;
        }

        private void HideAllMediaComponents()
        {
            HideMediaComponents();

            rbPic.Visible = false;
            rbAudio.Visible = false;
            rbVid.Visible = false;
        }

        private void ShowInitalMediaComponents()
        {
            rbPic.Visible = true;
            rbAudio.Visible = true;
            rbVid.Visible = true;
            ShowPicComponents();
        }

        private void ShowCommonMediaComponents()
        {
            lblFile.Visible = true;
            btnFile.Visible = true;
            rbVid.Visible = true;
        }

        private void DisableMediaComponents()
        {
            rbPic.Enabled = false;
            rbAudio.Enabled = false;
            rbVid.Enabled = false;
            btnFile.Enabled = false;
            txtFile.Enabled = false;
        }

        private void EnableMediaComponents()
        {
            rbPic.Enabled = true;
            rbAudio.Enabled = true;
            rbVid.Enabled = true;
            btnFile.Enabled = true;
            txtFile.Enabled = true;
        }

        private void ShowPicComponents()
        {
            HideMediaComponents();
            ShowCommonMediaComponents();
            pictureBox1.Visible = true;
            btnShow.Visible = true;
            rbPic.Visible = true;
        }

        private void ShowAudioVideoComponents()
        {
            HideMediaComponents();
            ShowCommonMediaComponents();
            MediaPlayer.Visible = true;
            btnPlay.Visible = true;
            btnStop.Visible = true;
        }


        private void DisableMessageComponents()
        {
            btnCancel.Enabled = false;
            btnSend.Enabled = false;
            cbxGroup.Enabled = false;
        }


        private void EnableMessgaeComponents()
        {
            btnCancel.Enabled = true;
            btnSend.Enabled = true;
            cbxGroup.Enabled = true;
        }

        private void UncheckAllListBoxItems()
        {
            if (CurrentTab == "R")
            {
                foreach (int itemCheckedIndex in clbMsgIn.CheckedIndices)
                {
                    clbMsgIn.SetItemChecked(itemCheckedIndex, false);
                }
            }
            else if (CurrentTab == "S")
            {
                foreach (int itemCheckedIndex in cblMsgOut.CheckedIndices)
                {
                    cblMsgOut.SetItemChecked(itemCheckedIndex, false);
                }
            }
        }

        private void ClearMesageFields()
        {
            txtRecipient.Text = "";
            txtText.Text = "";
            txtFile.Text = "";
            cbxGroup.Checked = false;
        }

        private int GetCountCheckedListBoxItems()
        {
            int res = 0;

            if (CurrentTab == "R")
                res = clbMsgIn.CheckedItems.Count;
            else
                res = cblMsgOut.CheckedItems.Count;

            return res;
        }

        private void GetRootDirectory()
        {
            //  To get the loction of the assembly root folder:
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            //  Once we have the path value we we get the directory using:
            var d = System.IO.Path.GetDirectoryName(path);

            var directory = d.Replace("bin\\Debug", "");

            RootDir = directory;
        }

        private void MediaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPic.Checked)
                ShowPicComponents();
            else
                ShowAudioVideoComponents();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            UncheckAllListBoxItems();

            ClearMesageFields();

            EnableMessgaeComponents();

            if (rbMMS.Checked)
            {
                ShowInitalMediaComponents();
                EnableMediaComponents();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearMesageFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                string file = RootDir;

                if (rbPic.Checked)
                {
                    file += "Image\\";
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.GIF;*.JPEG";
                }
                else if (rbAudio.Checked)
                {
                    file += "Audio\\";
                    dlg.Title = "Open Audio";
                    dlg.Filter = "Audio Files|*.wav;*.aac;*.wma;*.mp2;*.mp3;*.mpa;*.m3u;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi";
                }
                else if (rbVid.Checked)
                {
                    file += "Video\\";
                    dlg.Title = "Open Video";
                    dlg.Filter = "Video Files|*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mpe;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.mkv";
                }

                dlg.InitialDirectory = file;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var theFile = dlg.FileName.Replace(file, "");
                    txtFile.Text = theFile;
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (rbAudio.Checked && txtFile.TextLength > 0)
            {
                MediaPlayer.URL = RootDir + "Audio\\" + txtFile.Text;

                btnPlay.Enabled = false;
            }
            else if (rbVid.Checked && txtFile.TextLength > 0)
            {
                MediaPlayer.URL = RootDir + "Video\\" + txtFile.Text;

                btnPlay.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();

            btnPlay.Enabled = true;
        }

        private void MediaPlayer_MediaError(object sender, AxWMPLib._WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file,
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtFile.TextLength > 0)
                LoadPicture();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = 0;
            string sql = "";

            if (GetCountCheckedListBoxItems() > 0)
            {
                string id = GetSelectedID();

                sql = "Delete from messages where ID = '" + id + "'";


                res = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

                if (res > 0)
                {
                    MessageBox.Show(res + " message(s) deleted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearMesageFields();

                    LoadListBoxes();

                    if (rbMMS.Checked)
                        ShowPicComponents();
                }
                else
                {
                    MessageBox.Show("Message was not deleted \n Please try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No message selected", "Select a message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int res = 0;
            string sql = "";
            string recipient = "";
            string text = "";
            string file = "";
            int group = 0;

            if (cbxGroup.Checked)
            {
                group = 1;
            }

            if (rbSMS.Checked)
            {
                if (txtRecipient.TextLength > 0 && txtText.TextLength > 0)
                {
                    recipient = txtRecipient.Text;
                    text = txtText.Text;

                    sql = "Insert Into Messages(Status, Recipient, Text, isGroupMessage, MMS, Picture, Audio, Video, FileName)" +
                                        "Values('S', '" + recipient + "', '" + text + "', "+ group +", 0, 0, 0, 0, '' )";
                }
                else
                {
                    MessageBox.Show("Recipient and text inputs required", "Insufficient data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtRecipient.TextLength > 0 && txtText.TextLength > 0 && txtFile.TextLength > 0)
                {
                    recipient = txtRecipient.Text;
                    text = txtText.Text;
                    file = txtFile.Text;

                    int pic = 0;
                    int audio = 0;
                    int vid = 0;

                    if (rbPic.Checked)
                        pic = 1;
                    else if (rbAudio.Checked)
                        audio = 1;
                    else if (rbVid.Checked)
                        vid = 1;

                    sql = "Insert Into Messages(Status, Recipient, Text, isGroupMessage, MMS, Picture, Audio, Video, FileName)" +
                                        "Values('S', '" + recipient + "', '" + text + "', " + group + ", 1, " + pic + ", " + audio + ", " + vid + ", '" + file + "' )";
                }
                else
                {
                    MessageBox.Show("Recipient ,text and file name inputs required", "Insufficient data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (sql.Length > 0)
            {
                res = Data.ExecuteSqlNonQuery(sql, CommandType.Text);

                if (res > 0)
                {
                    MessageBox.Show(res + " message(s) sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearMesageFields();

                    if (rbMMS.Checked)
                        ShowPicComponents();

                    LoadListBoxes();
                }
                else
                {
                    MessageBox.Show("Message sending failed \n Try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Message not sent \n Try again", "Not sent", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Control requestingControl = (Control)sender;
            lblHelp.Text = (string)requestingControl.Tag;
            hlpevent.Handled = true;
        }
    }
}
