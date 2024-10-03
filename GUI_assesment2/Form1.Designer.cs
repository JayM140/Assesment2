namespace GUI_assesment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_data = new System.Windows.Forms.Button();
            this.n_data = new System.Windows.Forms.ListBox();
            this.sorting_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_input = new System.Windows.Forms.TextBox();
            this.search_ans = new System.Windows.Forms.ListBox();
            this.index_1 = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.num_replace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MidExtreme = new System.Windows.Forms.Button();
            this.MidExtremeBox = new System.Windows.Forms.TextBox();
            this.ModeButton = new System.Windows.Forms.Button();
            this.ModeDisplay = new System.Windows.Forms.TextBox();
            this.AverageButton = new System.Windows.Forms.Button();
            this.AverageDisplay = new System.Windows.Forms.TextBox();
            this.RangeButton = new System.Windows.Forms.Button();
            this.RangeDisplay = new System.Windows.Forms.TextBox();
            this.SequentialSearch = new System.Windows.Forms.Button();
            this.avg_button = new System.Windows.Forms.Button();
            this.avg_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // add_data
            // 
            this.add_data.Location = new System.Drawing.Point(50, 28);
            this.add_data.Name = "add_data";
            this.add_data.Size = new System.Drawing.Size(158, 72);
            this.add_data.TabIndex = 0;
            this.add_data.Text = "add data";
            this.add_data.UseVisualStyleBackColor = true;
            this.add_data.Click += new System.EventHandler(this.add_data_Click);
            // 
            // n_data
            // 
            this.n_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.n_data.FormattingEnabled = true;
            this.n_data.ItemHeight = 20;
            this.n_data.Location = new System.Drawing.Point(401, 28);
            this.n_data.MultiColumn = true;
            this.n_data.Name = "n_data";
            this.n_data.Size = new System.Drawing.Size(295, 324);
            this.n_data.TabIndex = 2;
            // 
            // sorting_button
            // 
            this.sorting_button.Location = new System.Drawing.Point(238, 28);
            this.sorting_button.Name = "sorting_button";
            this.sorting_button.Size = new System.Drawing.Size(146, 72);
            this.sorting_button.TabIndex = 3;
            this.sorting_button.Text = "sort";
            this.sorting_button.UseVisualStyleBackColor = true;
            this.sorting_button.Click += new System.EventHandler(this.sorting_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(50, 116);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(93, 26);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_input
            // 
            this.search_input.Location = new System.Drawing.Point(50, 148);
            this.search_input.Name = "search_input";
            this.search_input.Size = new System.Drawing.Size(92, 20);
            this.search_input.TabIndex = 5;
            // 
            // search_ans
            // 
            this.search_ans.FormattingEnabled = true;
            this.search_ans.Location = new System.Drawing.Point(49, 174);
            this.search_ans.Name = "search_ans";
            this.search_ans.Size = new System.Drawing.Size(93, 30);
            this.search_ans.TabIndex = 6;
            // 
            // index_1
            // 
            this.index_1.Location = new System.Drawing.Point(238, 148);
            this.index_1.Name = "index_1";
            this.index_1.Size = new System.Drawing.Size(100, 20);
            this.index_1.TabIndex = 7;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(238, 119);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 8;
            this.change.Text = "change";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // num_replace
            // 
            this.num_replace.Location = new System.Drawing.Point(238, 174);
            this.num_replace.Name = "num_replace";
            this.num_replace.Size = new System.Drawing.Size(100, 20);
            this.num_replace.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "index";
            // 
            // MidExtreme
            // 
            this.MidExtreme.Location = new System.Drawing.Point(50, 230);
            this.MidExtreme.Name = "MidExtreme";
            this.MidExtreme.Size = new System.Drawing.Size(75, 23);
            this.MidExtreme.TabIndex = 12;
            this.MidExtreme.Text = "button1";
            this.MidExtreme.UseVisualStyleBackColor = true;
            this.MidExtreme.Click += new System.EventHandler(this.MidExtreme_Click);
            // 
            // MidExtremeBox
            // 
            this.MidExtremeBox.Location = new System.Drawing.Point(49, 260);
            this.MidExtremeBox.Name = "MidExtremeBox";
            this.MidExtremeBox.Size = new System.Drawing.Size(76, 20);
            this.MidExtremeBox.TabIndex = 13;
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(144, 230);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(75, 23);
            this.ModeButton.TabIndex = 14;
            this.ModeButton.Text = "button1";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // ModeDisplay
            // 
            this.ModeDisplay.Location = new System.Drawing.Point(144, 260);
            this.ModeDisplay.Name = "ModeDisplay";
            this.ModeDisplay.Size = new System.Drawing.Size(75, 20);
            this.ModeDisplay.TabIndex = 15;
            // 
            // AverageButton
            // 
            this.AverageButton.Location = new System.Drawing.Point(238, 229);
            this.AverageButton.Name = "AverageButton";
            this.AverageButton.Size = new System.Drawing.Size(75, 23);
            this.AverageButton.TabIndex = 16;
            this.AverageButton.Text = "button1";
            this.AverageButton.UseVisualStyleBackColor = true;
            this.AverageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // AverageDisplay
            // 
            this.AverageDisplay.Location = new System.Drawing.Point(238, 259);
            this.AverageDisplay.Name = "AverageDisplay";
            this.AverageDisplay.Size = new System.Drawing.Size(75, 20);
            this.AverageDisplay.TabIndex = 17;
            // 
            // RangeButton
            // 
            this.RangeButton.Location = new System.Drawing.Point(49, 302);
            this.RangeButton.Name = "RangeButton";
            this.RangeButton.Size = new System.Drawing.Size(75, 23);
            this.RangeButton.TabIndex = 18;
            this.RangeButton.Text = "button1";
            this.RangeButton.UseVisualStyleBackColor = true;
            this.RangeButton.Click += new System.EventHandler(this.RangeButton_Click);
            // 
            // RangeDisplay
            // 
            this.RangeDisplay.Location = new System.Drawing.Point(50, 331);
            this.RangeDisplay.Name = "RangeDisplay";
            this.RangeDisplay.Size = new System.Drawing.Size(75, 20);
            this.RangeDisplay.TabIndex = 19;
            this.RangeDisplay.TextChanged += new System.EventHandler(this.RangeDisplay_TextChanged);
            // 
            // SequentialSearch
            // 
            this.SequentialSearch.Location = new System.Drawing.Point(154, 302);
            this.SequentialSearch.Name = "SequentialSearch";
            this.SequentialSearch.Size = new System.Drawing.Size(75, 23);
            this.SequentialSearch.TabIndex = 20;
            this.SequentialSearch.Text = "button1";
            this.SequentialSearch.UseVisualStyleBackColor = true;
            this.SequentialSearch.Click += new System.EventHandler(this.SequentialSearch_Click);
            // 
            // avg_button
            // 
            this.avg_button.Location = new System.Drawing.Point(238, 302);
            this.avg_button.Name = "avg_button";
            this.avg_button.Size = new System.Drawing.Size(75, 23);
            this.avg_button.TabIndex = 21;
            this.avg_button.Text = "button1";
            this.avg_button.UseVisualStyleBackColor = true;
            this.avg_button.Click += new System.EventHandler(this.avg_button_Click);
            // 
            // avg_out
            // 
            this.avg_out.Location = new System.Drawing.Point(238, 331);
            this.avg_out.Name = "avg_out";
            this.avg_out.Size = new System.Drawing.Size(100, 20);
            this.avg_out.TabIndex = 22;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(732, 384);
            this.Controls.Add(this.avg_out);
            this.Controls.Add(this.avg_button);
            this.Controls.Add(this.SequentialSearch);
            this.Controls.Add(this.RangeDisplay);
            this.Controls.Add(this.RangeButton);
            this.Controls.Add(this.AverageDisplay);
            this.Controls.Add(this.AverageButton);
            this.Controls.Add(this.ModeDisplay);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MidExtremeBox);
            this.Controls.Add(this.MidExtreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_replace);
            this.Controls.Add(this.change);
            this.Controls.Add(this.index_1);
            this.Controls.Add(this.search_ans);
            this.Controls.Add(this.search_input);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.sorting_button);
            this.Controls.Add(this.n_data);
            this.Controls.Add(this.add_data);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_data;
        private System.Windows.Forms.ListBox n_data;
        private System.Windows.Forms.Button sorting_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_input;
        private System.Windows.Forms.ListBox search_ans;
        private System.Windows.Forms.TextBox index_1;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox num_replace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MidExtreme;
        private System.Windows.Forms.TextBox MidExtremeBox;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.TextBox ModeDisplay;
        private System.Windows.Forms.Button AverageButton;
        private System.Windows.Forms.TextBox AverageDisplay;
        private System.Windows.Forms.Button RangeButton;
        private System.Windows.Forms.TextBox RangeDisplay;
        private System.Windows.Forms.Button SequentialSearch;
        private System.Windows.Forms.Button avg_button;
        private System.Windows.Forms.TextBox avg_out;
    }
}

