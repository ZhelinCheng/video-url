using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lulu
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        Video _video = new Video();

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            string url = "";

            string pattern = @"[^\.]+(?=\.com)";

            Match m = Regex.Match(inpUrl.Text, pattern);

            switch (m.Value)
            {
                //优酷视频链接
                case "youku":
                    url = _video.GetYouKu(inpUrl.Text);
                    break;
                //腾讯视频链接
                case "qq":
                    url = _video.GetQq(inpUrl.Text);
                    break;
                default: /* 可选的 */
                    MessageBox.Show("不支持该视频链接！");
                    break;
            }

            if (url != "") {
                inpShow.Enabled = true;
                btnCopy.Enabled = true;
                inpShow.Text = url;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(inpShow.Text);
            MessageBox.Show("复制成功！");
        }
    }
}
