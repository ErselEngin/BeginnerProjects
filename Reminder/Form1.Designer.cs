namespace Reminder
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txt_title = new TextBox();
            rtb_notes = new RichTextBox();
            btn_open = new Button();
            btn_close = new Button();
            btn_save = new Button();
            btn_delete = new Button();
            openFileDialog1 = new OpenFileDialog();
            dtp_date = new DateTimePicker();
            btn_setReminder = new Button();
            dtp_clock = new DateTimePicker();
            SuspendLayout();
            // 
            // txt_title
            // 
            txt_title.Location = new Point(12, 12);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(300, 23);
            txt_title.TabIndex = 0;
            txt_title.Text = "Title";
            // 
            // rtb_notes
            // 
            rtb_notes.Location = new Point(12, 41);
            rtb_notes.Name = "rtb_notes";
            rtb_notes.Size = new Size(300, 408);
            rtb_notes.TabIndex = 1;
            rtb_notes.Text = "Your notes goes here...";
            // 
            // btn_open
            // 
            btn_open.Location = new Point(318, 11);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(75, 23);
            btn_open.TabIndex = 2;
            btn_open.Text = "Open";
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(399, 11);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(75, 23);
            btn_close.TabIndex = 3;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(318, 426);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(399, 426);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            // 
            // dtp_date
            // 
            dtp_date.CustomFormat = "";
            dtp_date.Location = new Point(318, 108);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(156, 23);
            dtp_date.TabIndex = 6;
            // 
            // btn_setReminder
            // 
            btn_setReminder.Location = new Point(318, 165);
            btn_setReminder.Name = "btn_setReminder";
            btn_setReminder.Size = new Size(156, 23);
            btn_setReminder.TabIndex = 8;
            btn_setReminder.Text = "Set Reminder";
            btn_setReminder.UseVisualStyleBackColor = true;
            btn_setReminder.Click += btn_setReminder_Click;
            // 
            // dtp_clock
            // 
            dtp_clock.CustomFormat = "";
            dtp_clock.Format = DateTimePickerFormat.Time;
            dtp_clock.Location = new Point(359, 136);
            dtp_clock.Name = "dtp_clock";
            dtp_clock.Size = new Size(78, 23);
            dtp_clock.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(dtp_clock);
            Controls.Add(btn_setReminder);
            Controls.Add(dtp_date);
            Controls.Add(btn_delete);
            Controls.Add(btn_save);
            Controls.Add(btn_close);
            Controls.Add(btn_open);
            Controls.Add(rtb_notes);
            Controls.Add(txt_title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Reminder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_title;
        private RichTextBox rtb_notes;
        private Button btn_open;
        private Button btn_close;
        private Button btn_save;
        private Button btn_delete;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dtp_date;
        private Button btn_setReminder;
        private DateTimePicker dtp_clock;
    }
}