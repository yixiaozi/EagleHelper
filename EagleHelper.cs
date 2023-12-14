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
            //遍历Eagle库文件夹所有metadata.json文件
            string[] files = Directory.GetFiles(eagleFolderPath.Text + @"\images", "metadata.json", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                //读取metadata.json文件内容
                string json = File.ReadAllText(file);
                //反序列化为对象
                JObject obj = JObject.Parse(json);
                //如果folders个数多余一个，则保留第一个
                if (obj["folders"].Count() > 1)
                {
                    obj["folders"] = new JArray(obj["folders"][0]);
                    //序列化为json字符串
                    string newJson = obj.ToString();
                    //删除换行符
                    newJson = newJson.Replace(Environment.NewLine, "");
                    //写入文件
                    File.WriteAllText(file, newJson);
                }
            }
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
        }
    }
}