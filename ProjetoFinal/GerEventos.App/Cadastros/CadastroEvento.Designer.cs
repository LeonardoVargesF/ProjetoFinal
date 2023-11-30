namespace GerEventos.App.Cadastros
{
    partial class CadastroEvento
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
            this.txtData = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cboCidade = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.materialTabControl.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl
            // 
            this.materialTabControl.Size = new System.Drawing.Size(478, 258);
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.txtDescricao);
            this.tabPageCadastro.Controls.Add(this.txtId);
            this.tabPageCadastro.Controls.Add(this.cboCidade);
            this.tabPageCadastro.Controls.Add(this.txtData);
            this.tabPageCadastro.Controls.Add(this.txtNome);
            this.tabPageCadastro.Size = new System.Drawing.Size(470, 223);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtNome, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtData, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.cboCidade, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtId, 0);
            this.tabPageCadastro.Controls.SetChildIndex(this.txtDescricao, 0);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.HideSelection = true;
            this.txtNome.Hint = "Nome do Evento";
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(7, 6);
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
            this.txtNome.Size = new System.Drawing.Size(365, 48);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.TrailingIcon = null;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtData
            // 
            this.txtData.AllowPromptAsInput = true;
            this.txtData.AnimateReadOnly = false;
            this.txtData.AsciiOnly = false;
            this.txtData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtData.BeepOnError = false;
            this.txtData.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.HidePromptOnLeave = false;
            this.txtData.HideSelection = true;
            this.txtData.Hint = "Data do Evento";
            this.txtData.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(7, 60);
            this.txtData.Mask = "99/99/9999";
            this.txtData.MaxLength = 32767;
            this.txtData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PrefixSuffixText = null;
            this.txtData.PromptChar = '_';
            this.txtData.ReadOnly = false;
            this.txtData.RejectInputOnFirstFailure = false;
            this.txtData.ResetOnPrompt = true;
            this.txtData.ResetOnSpace = true;
            this.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(116, 48);
            this.txtData.SkipLiterals = true;
            this.txtData.TabIndex = 3;
            this.txtData.TabStop = false;
            this.txtData.Text = "  /  /";
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtData.TrailingIcon = null;
            this.txtData.UseSystemPasswordChar = false;
            this.txtData.ValidatingType = null;
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
            this.cboCidade.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Hint = "Cidade";
            this.cboCidade.IntegralHeight = false;
            this.cboCidade.ItemHeight = 43;
            this.cboCidade.Location = new System.Drawing.Point(129, 59);
            this.cboCidade.MaxDropDownItems = 4;
            this.cboCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(333, 49);
            this.cboCidade.StartIndex = 0;
            this.cboCidade.TabIndex = 4;
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
            this.txtId.Location = new System.Drawing.Point(378, 6);
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
            this.txtId.Size = new System.Drawing.Size(84, 48);
            this.txtId.TabIndex = 5;
            this.txtId.TabStop = false;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtId.TrailingIcon = null;
            this.txtId.UseSystemPasswordChar = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.AnimateReadOnly = false;
            this.txtDescricao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescricao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescricao.HideSelection = true;
            this.txtDescricao.Hint = "Descrição do Evento";
            this.txtDescricao.LeadingIcon = null;
            this.txtDescricao.Location = new System.Drawing.Point(6, 114);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PrefixSuffixText = null;
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(456, 48);
            this.txtDescricao.TabIndex = 6;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.TrailingIcon = null;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // CadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 325);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CadastroEvento";
            this.Text = "Cadastro de Evento";
            this.materialTabControl.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtData;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
    }
}