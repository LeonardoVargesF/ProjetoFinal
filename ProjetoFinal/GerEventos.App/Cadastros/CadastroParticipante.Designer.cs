namespace GerEventos.App.Cadastros
{
    partial class CadastroParticipante
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
            this.txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtTelefone = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.cboCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(576, 319);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.cboCidade);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.txtTelefone);
            this.tabPageCadastro.Controls.Add(this.txtCPF);
            this.tabPageCadastro.Controls.Add(this.txtEmail);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(568, 284);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtEmail, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtCPF, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtTelefone, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCidade, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(7, 9);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PrefixSuffixText = null;
            this.txtNome.ReadOnly = false;
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(461, 48);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(7, 63);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(548, 48);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtCPF
            // 
            this.txtCPF.AllowPromptAsInput = true;
            this.txtCPF.AnimateReadOnly = false;
            this.txtCPF.AsciiOnly = false;
            this.txtCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCPF.BeepOnError = false;
            this.txtCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.Depth = 0;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCPF.HidePromptOnLeave = false;
            this.txtCPF.HideSelection = true;
            this.txtCPF.Hint = "CPF";
            this.txtCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCPF.LeadingIcon = null;
            this.txtCPF.Location = new System.Drawing.Point(7, 117);
            this.txtCPF.Mask = "999.999.999-99";
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.PrefixSuffixText = null;
            this.txtCPF.PromptChar = '_';
            this.txtCPF.ReadOnly = false;
            this.txtCPF.RejectInputOnFirstFailure = false;
            this.txtCPF.ResetOnPrompt = true;
            this.txtCPF.ResetOnSpace = true;
            this.txtCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.ShortcutsEnabled = true;
            this.txtCPF.Size = new System.Drawing.Size(548, 48);
            this.txtCPF.SkipLiterals = true;
            this.txtCPF.TabIndex = 4;
            this.txtCPF.TabStop = false;
            this.txtCPF.Text = "   ,   ,   -";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCPF.TrailingIcon = null;
            this.txtCPF.UseSystemPasswordChar = false;
            this.txtCPF.ValidatingType = null;
            // 
            // txtTelefone
            // 
            this.txtTelefone.AllowPromptAsInput = true;
            this.txtTelefone.AnimateReadOnly = false;
            this.txtTelefone.AsciiOnly = false;
            this.txtTelefone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefone.BeepOnError = false;
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefone.HidePromptOnLeave = false;
            this.txtTelefone.HideSelection = true;
            this.txtTelefone.Hint = "Telefone";
            this.txtTelefone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTelefone.LeadingIcon = null;
            this.txtTelefone.Location = new System.Drawing.Point(7, 171);
            this.txtTelefone.Mask = "(99) 99999-9999";
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PrefixSuffixText = null;
            this.txtTelefone.PromptChar = '_';
            this.txtTelefone.ReadOnly = false;
            this.txtTelefone.RejectInputOnFirstFailure = false;
            this.txtTelefone.ResetOnPrompt = true;
            this.txtTelefone.ResetOnSpace = true;
            this.txtTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(127, 48);
            this.txtTelefone.SkipLiterals = true;
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.Text = "(  )      -";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTelefone.TrailingIcon = null;
            this.txtTelefone.UseSystemPasswordChar = false;
            this.txtTelefone.ValidatingType = null;
            // 
            // txtId
            // 
            this.txtId.AnimateReadOnly = false;
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Depth = 0;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtId.HideSelection = true;
            this.txtId.Hint = "Id";
            this.txtId.LeadingIcon = null;
            this.txtId.Location = new System.Drawing.Point(474, 9);
            this.txtId.MaxLength = 32767;
            this.txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PrefixSuffixText = null;
            this.txtId.ReadOnly = true;
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(81, 48);
            this.txtId.TabIndex = 6;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // cboCidade
            // 
            this.cboCidade.AutoResize = false;
            this.cboCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCidade.Depth = 0;
            this.cboCidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCidade.DropDownHeight = 174;
            this.cboCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCidade.DropDownWidth = 121;
            this.cboCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Hint = "Cidade";
            this.cboCidade.IntegralHeight = false;
            this.cboCidade.ItemHeight = 43;
            this.cboCidade.Location = new System.Drawing.Point(140, 170);
            this.cboCidade.MaxDropDownItems = 4;
            this.cboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(415, 49);
            this.cboCidade.StartIndex = 0;
            this.cboCidade.TabIndex = 14;
            // 
            // CadastroParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 386);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroParticipante";
            this.Text = "Cadastro de Participante";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTelefone;
        private ReaLTaiizor.Controls.MaterialComboBox cboCidade;
    }
}