using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace AlgoLab4
{
    public partial class Form1 : Form
    {
        private BinarySearchTree BST { get; set; }
        private DoublyLinkedList<string> List { get; set; }
        private Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeTreeView()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();
            if (BST != null && BST.Root != null)
            {
                TreeNode root = BST.Root;
                var treeNode = treeView1.Nodes.Add(root.Value);
                AppendToTreeView(treeNode, root.Left);
                AppendToTreeView(treeNode, root.Right);
            }
            else
            {
                treeView1.Nodes.Add("!!EMPTY!!");
            }
            treeView1.ExpandAll();
            treeView1.EndUpdate();
        }
        private void AppendToTreeView(System.Windows.Forms.TreeNode currViewNode, TreeNode? node)
        {
            if (node != null)
            {
                var treeNode = currViewNode.Nodes.Add(node.Value);
                if (node.Left != null || node.Right != null)
                {
                    AppendToTreeView(treeNode, node.Left);
                    AppendToTreeView(treeNode, node.Right);
                }
            }
            else
            {
                currViewNode.Nodes.Add("!!EMPTY!!");
            }
        }

        private void bt_file_open_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        textBox1.Text = fileContent;
                        BST = BinarySearchTree.CreateFromStringOfWords(fileContent);
                        lb_max_depth.Text = "Max depth: " + BST.MaxDepth;
                        InitializeTreeView();
                        string[] words = fileContent.Replace("\r", " ").Replace("\n", " ").Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        List = new DoublyLinkedList<string>();
                        foreach (string word in words)
                        {
                            List.AddToBack(word);
                        }
                    }
                }
            }
        }

        private void lb_forward_Click(object sender, EventArgs e)
        {
            if (BST != null)
            {
                List<string> output = BST.TraverseForward();
                tb_sort_output.Text = string.Join("\n ", output);
            }
            else
            {
                tb_sort_output.Text = "";
            }
        }

        private void lb_backward_Click(object sender, EventArgs e)
        {
            if (BST != null)
            {
                List<string> output = BST.TraverseBackward();
                tb_sort_output.Text = string.Join("\n ", output);
            }
            else
            {
                tb_sort_output.Text = "";
            }
        }

        private void bt_search_for_elem_Click(object sender, EventArgs e)
        {
            if (BST != null)
            {
                string word = tb_search_for_elem.Text.Trim();
                stopwatch.Restart();
                TreeNode treeNode = BST.Find(word, BST.Root);
                stopwatch.Stop();
                string treeReturn = treeNode != null ? treeNode.Value : "не найдено";
                long elapsedTicksTree = stopwatch.ElapsedTicks;
                long elapsedMsTree = (elapsedTicksTree / Stopwatch.Frequency) * 1000;
                stopwatch.Restart();
                DoubleListNode<string> listNode = List.Find(word);
                stopwatch.Stop();
                string listReturn = listNode != null ? listNode.Data : "не найдено";
                long elapsedTicksList = stopwatch.ElapsedTicks;
                long elapsedMsList = (elapsedTicksList / Stopwatch.Frequency) * 1000;
                lb_tree_time.Text = $"Время поиска в дереве: {elapsedTicksTree.ToString()} ({elapsedMsTree.ToString()}мс.)";
                lb_list_time.Text = $"Время поиска в списке: {elapsedTicksList.ToString()} ({elapsedMsList.ToString()}мс.)";
                lb_tree_return.Text = "Дерево: " + treeReturn;
                lb_list_return.Text = "Список: " + listReturn;
            }
        }

        private void lb_list_time_Click(object sender, EventArgs e)
        {

        }
    }
}