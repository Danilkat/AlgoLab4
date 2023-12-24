namespace AlgoLab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_file_open = new Button();
            treeView1 = new TreeView();
            lb_forward = new Button();
            lb_backward = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tb_search_for_elem = new TextBox();
            bt_search_for_elem = new Button();
            lb_tree_time = new Label();
            lb_list_time = new Label();
            lb_tree_return = new Label();
            lb_list_return = new Label();
            tb_sort_output = new TextBox();
            lb_max_depth = new Label();
            SuspendLayout();
            // 
            // bt_file_open
            // 
            bt_file_open.Location = new Point(4, 8);
            bt_file_open.Name = "bt_file_open";
            bt_file_open.Size = new Size(106, 23);
            bt_file_open.TabIndex = 0;
            bt_file_open.Text = "Открыть файл";
            bt_file_open.UseVisualStyleBackColor = true;
            bt_file_open.Click += bt_file_open_Click;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(357, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(431, 471);
            treeView1.TabIndex = 1;
            // 
            // lb_forward
            // 
            lb_forward.Location = new Point(202, 196);
            lb_forward.Name = "lb_forward";
            lb_forward.Size = new Size(138, 23);
            lb_forward.TabIndex = 2;
            lb_forward.Text = "В прямом порядке";
            lb_forward.UseVisualStyleBackColor = true;
            lb_forward.Click += lb_forward_Click;
            // 
            // lb_backward
            // 
            lb_backward.Location = new Point(202, 225);
            lb_backward.Name = "lb_backward";
            lb_backward.Size = new Size(138, 23);
            lb_backward.TabIndex = 3;
            lb_backward.Text = "В обратном порядке";
            lb_backward.UseVisualStyleBackColor = true;
            lb_backward.Click += lb_backward_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 178);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 4;
            label1.Text = "Сортированный вывод";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(106, 92);
            textBox1.TabIndex = 6;
            // 
            // tb_search_for_elem
            // 
            tb_search_for_elem.Location = new Point(116, 37);
            tb_search_for_elem.Name = "tb_search_for_elem";
            tb_search_for_elem.Size = new Size(163, 23);
            tb_search_for_elem.TabIndex = 7;
            // 
            // bt_search_for_elem
            // 
            bt_search_for_elem.Location = new Point(116, 8);
            bt_search_for_elem.Name = "bt_search_for_elem";
            bt_search_for_elem.Size = new Size(115, 23);
            bt_search_for_elem.TabIndex = 8;
            bt_search_for_elem.Text = "Найти элемент";
            bt_search_for_elem.UseVisualStyleBackColor = true;
            bt_search_for_elem.Click += bt_search_for_elem_Click;
            // 
            // lb_tree_time
            // 
            lb_tree_time.AutoSize = true;
            lb_tree_time.Location = new Point(116, 63);
            lb_tree_time.Name = "lb_tree_time";
            lb_tree_time.Size = new Size(136, 15);
            lb_tree_time.TabIndex = 9;
            lb_tree_time.Text = "Время поиска в дереве:";
            // 
            // lb_list_time
            // 
            lb_list_time.AutoSize = true;
            lb_list_time.Location = new Point(116, 89);
            lb_list_time.Name = "lb_list_time";
            lb_list_time.Size = new Size(137, 15);
            lb_list_time.TabIndex = 10;
            lb_list_time.Text = "Время поиска в списке:";
            lb_list_time.Click += lb_list_time_Click;
            // 
            // lb_tree_return
            // 
            lb_tree_return.AutoSize = true;
            lb_tree_return.Location = new Point(116, 114);
            lb_tree_return.Name = "lb_tree_return";
            lb_tree_return.Size = new Size(50, 15);
            lb_tree_return.TabIndex = 11;
            lb_tree_return.Text = "Дерево:";
            // 
            // lb_list_return
            // 
            lb_list_return.AutoSize = true;
            lb_list_return.Location = new Point(116, 133);
            lb_list_return.Name = "lb_list_return";
            lb_list_return.Size = new Size(51, 15);
            lb_list_return.TabIndex = 12;
            lb_list_return.Text = "Список:";
            // 
            // tb_sort_output
            // 
            tb_sort_output.Location = new Point(181, 293);
            tb_sort_output.Multiline = true;
            tb_sort_output.Name = "tb_sort_output";
            tb_sort_output.ReadOnly = true;
            tb_sort_output.ScrollBars = ScrollBars.Both;
            tb_sort_output.Size = new Size(170, 190);
            tb_sort_output.TabIndex = 13;
            // 
            // lb_max_depth
            // 
            lb_max_depth.AutoSize = true;
            lb_max_depth.Location = new Point(9, 192);
            lb_max_depth.Name = "lb_max_depth";
            lb_max_depth.Size = new Size(38, 15);
            lb_max_depth.TabIndex = 14;
            lb_max_depth.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(lb_max_depth);
            Controls.Add(lb_list_return);
            Controls.Add(lb_tree_return);
            Controls.Add(lb_list_time);
            Controls.Add(lb_tree_time);
            Controls.Add(bt_search_for_elem);
            Controls.Add(tb_search_for_elem);
            Controls.Add(textBox1);
            Controls.Add(tb_sort_output);
            Controls.Add(label1);
            Controls.Add(lb_backward);
            Controls.Add(lb_forward);
            Controls.Add(treeView1);
            Controls.Add(bt_file_open);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_file_open;
        private TreeView treeView1;
        private Button lb_forward;
        private Button lb_backward;
        private Label label1;
        private TextBox textBox1;
        private TextBox tb_search_for_elem;
        private Button bt_search_for_elem;
        private Label lb_tree_time;
        private Label lb_list_time;
        private Label lb_tree_return;
        private Label lb_list_return;
        private TextBox tb_sort_output;
        private Label lb_max_depth;
    }
}