namespace qwe11
{
    partial class Tester
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tester));
            this.var1 = new System.Windows.Forms.CheckBox();
            this.var2 = new System.Windows.Forms.CheckBox();
            this.var3 = new System.Windows.Forms.CheckBox();
            this.var4 = new System.Windows.Forms.CheckBox();
            this.question = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Button();
            this.testchoice = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TrackBar();
            this.accept = new System.Windows.Forms.Button();
            this.quantityScroll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // var1
            // 
            resources.ApplyResources(this.var1, "var1");
            this.var1.Name = "var1";
            this.var1.UseVisualStyleBackColor = true;
            this.var1.Click += new System.EventHandler(this.var_Click);
            // 
            // var2
            // 
            resources.ApplyResources(this.var2, "var2");
            this.var2.Name = "var2";
            this.var2.UseVisualStyleBackColor = true;
            this.var2.Click += new System.EventHandler(this.var_Click);
            // 
            // var3
            // 
            resources.ApplyResources(this.var3, "var3");
            this.var3.Name = "var3";
            this.var3.UseVisualStyleBackColor = true;
            this.var3.Click += new System.EventHandler(this.var_Click);
            // 
            // var4
            // 
            resources.ApplyResources(this.var4, "var4");
            this.var4.Name = "var4";
            this.var4.UseVisualStyleBackColor = true;
            this.var4.Click += new System.EventHandler(this.var_Click);
            // 
            // question
            // 
            resources.ApplyResources(this.question, "question");
            this.question.Name = "question";
            this.question.UseWaitCursor = true;
            // 
            // answer
            // 
            resources.ApplyResources(this.answer, "answer");
            this.answer.Name = "answer";
            this.answer.UseVisualStyleBackColor = true;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // testchoice
            // 
            resources.ApplyResources(this.testchoice, "testchoice");
            this.testchoice.Name = "testchoice";
            this.testchoice.UseVisualStyleBackColor = true;
            this.testchoice.Click += new System.EventHandler(this.testchoice_Click);
            // 
            // quantity
            // 
            this.quantity.LargeChange = 1;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Minimum = 1;
            this.quantity.Name = "quantity";
            this.quantity.Value = 1;
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_Changed);
            // 
            // accept
            // 
            resources.ApplyResources(this.accept, "accept");
            this.accept.Name = "accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // quantityScroll
            // 
            resources.ApplyResources(this.quantityScroll, "quantityScroll");
            this.quantityScroll.Name = "quantityScroll";
            // 
            // Tester
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quantityScroll);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.testchoice);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.question);
            this.Controls.Add(this.var4);
            this.Controls.Add(this.var3);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Name = "Tester";
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox var1;
        private System.Windows.Forms.CheckBox var3;
        private System.Windows.Forms.CheckBox var4;
        private System.Windows.Forms.CheckBox var2;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button answer;
        private System.Windows.Forms.Button testchoice;
        private System.Windows.Forms.TrackBar quantity;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label quantityScroll;
    }
}

