using Newtonsoft.Json.Linq;

namespace EagleHelper
{
    public partial class EagleHelper : Form
    {
        public EagleHelper()
        {
            InitializeComponent();
        }

        private void OnlyOneFolder_Click(object sender, EventArgs e)
        {
            //����Eagle���ļ�������metadata.json�ļ�
            string[] files = Directory.GetFiles(eagleFolderPath.Text + @"\images", "metadata.json", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                //��ȡmetadata.json�ļ�����
                string json = File.ReadAllText(file);
                //�����л�Ϊ����
                JObject obj = JObject.Parse(json);
                //���folders��������һ����������һ��
                if (obj["folders"].Count() > 1)
                {
                    obj["folders"] = new JArray(obj["folders"][0]);
                    //���л�Ϊjson�ַ���
                    string newJson = obj.ToString();
                    //ɾ�����з�
                    newJson = newJson.Replace(Environment.NewLine, "");
                    //д���ļ�
                    File.WriteAllText(file, newJson);
                }
            }
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
        }
    }
}