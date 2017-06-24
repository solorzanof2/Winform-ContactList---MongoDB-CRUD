using ContactList.Controllers;
using ContactList.Enums;
using ContactList.Exceptions;
using ContactList.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
	public partial class frmMain : Form
	{

		private CurrentProcess _currentProcess;

		private DialogResult _user;

		private ContactsListController _controller;

		private int _rowIndex;

		private string _message;

		private bool _hasEmailException;
		private bool _hasDate;

		private Contact _newContact;

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;
				return cp;
			}
		}
		private string Id
		{
			get
			{
				return dtg[Convert.ToInt32(Col.ID), _rowIndex].Value.ToString();
			}
		}
		private string FullName
		{
			get
			{
				return dtg[Convert.ToInt32(Col.Name), _rowIndex].Value.ToString();
			}
		}
		private string Email
		{
			get
			{
				return dtg[Convert.ToInt32(Col.Email), _rowIndex].Value.ToString();
			}
		}
		private string Phone
		{
			get
			{
				return dtg[Convert.ToInt32(Col.Phone), _rowIndex].Value.ToString();
			}
		}
		private DateTime Birthday
		{
			get
			{
				return Convert.ToDateTime(dtg[Convert.ToInt32(Col.Birthday), _rowIndex].Value);
			}
		}

		public frmMain(ContactsListController controller)
		{
			InitializeComponent();
			_currentProcess = CurrentProcess.Init;
			_message = "0";
			_controller = controller;
			_hasEmailException = false;
			_hasDate = false;

			#region TEXTBOX ADD EVENTS

			txtFullName.GotFocus += txtFullName_GotFocus;
			txtFullName.Click += txtFullName_Click;
			txtFullName.KeyPress += txtFullName_KeyPress;
			txtFullName.KeyDown += txtFullName_KeyDown;
			txtFullName.TextChanged += txtFullName_TextChanged;

			txtEmail.GotFocus += txtEmail_GotFocus;
			txtEmail.Click += txtEmail_Click;
			txtEmail.KeyPress += txtEmail_KeyPress;
			txtEmail.KeyDown += txtEmail_KeyDown;

			txtPhone.GotFocus += txtPhone_GotFocus;
			txtPhone.Click += txtPhone_Click;
			txtPhone.KeyPress += txtPhone_KeyPress;
			txtPhone.KeyDown += txtPhone_KeyDown;
			txtPhone.TextChanged += txtPhone_TextChanged;

			txtBirth.ValueChanged += txtBirth_ValueChanged;

			#endregion
		}

		#region TEXTBOX EVENTS

		private void txtFullName_GotFocus(object sender, EventArgs e)
		{
			txtFullName.Select(0, txtFullName.Text.Length);
		}

		private void txtFullName_Click(object sender, EventArgs e)
		{
			txtFullName.Select(0, txtFullName.Text.Length);
		}

		private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals((char)Keys.Enter))
			{
				txtEmail.Focus();
				e.Handled = true;
			}
		}

		private void txtFullName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers.Equals(Keys.Control)) e.Handled = true;
		}

		private void txtFullName_TextChanged(object sender, EventArgs e)
		{
			switch (_currentProcess)
			{
				case CurrentProcess.New:
					_newContact.Name = txtFullName.Text.ToUpper();
					break;
				case CurrentProcess.Edition:
					_controller.CurrentContact.Name = txtFullName.Text.ToUpper();
					break;
			}
		}

		private void txtEmail_GotFocus(object sender, EventArgs e)
		{
			txtEmail.Select(0, txtEmail.Text.Length);
		}

		private void txtEmail_Click(object sender, EventArgs e)
		{
			txtEmail.Select(0, txtEmail.Text.Length);
		}

		private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals((char)Keys.Enter))
			{

				switch (ValidationHelper.VerifyEmail(txtEmail.Text))
				{
					case EmailVerification.True:
						switch (_currentProcess)
						{
							case CurrentProcess.New:
								_newContact.Email = txtEmail.Text.ToLower();
								break;
							case CurrentProcess.Edition:
								_controller.CurrentContact.Email = txtEmail.Text.ToLower();
								break;
						}
						_hasEmailException = false;
						txtEmail.BackColor = Color.White;
						break;
					case EmailVerification.False:
						txtEmail.BackColor = Color.LightCoral;
						_hasEmailException = true;
						break;
				}
				e.Handled = true;
				txtPhone.Focus();
			}
		}

		private void txtEmail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers.Equals(Keys.Control)) e.Handled = true;
		}

		private void txtPhone_GotFocus(object sender, EventArgs e)
		{
			txtPhone.Select(0, txtPhone.Text.Length);
		}

		private void txtPhone_Click(object sender, EventArgs e)
		{
			txtPhone.Select(0, txtPhone.Text.Length);
		}

		private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar.Equals((char)Keys.Enter))
			{
				e.Handled = true;
				txtBirth.Focus();
			}
			e.Handled = !(char.IsDigit(e.KeyChar) || Convert.ToInt32((e.KeyChar)).Equals(8));
		}

		private void txtPhone_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers.Equals(Keys.Control)) e.Handled = true;
		}

		private void txtPhone_TextChanged(object sender, EventArgs e)
		{
			switch (_currentProcess)
			{
				case CurrentProcess.New:
					_newContact.Phone = txtPhone.Text;
					break;
				case CurrentProcess.Edition:
					_controller.CurrentContact.Phone = txtPhone.Text;
					break;
			}
		}

		private void txtBirth_ValueChanged(object sender, EventArgs e)
		{
			switch (_currentProcess)
			{
				case CurrentProcess.New:
					_newContact.Birth = txtBirth.Value;
					_hasDate = true;
					break;
				case CurrentProcess.Edition:
					_controller.CurrentContact.Birth = txtBirth.Value;
					_hasDate = true;
					break;
			}
		}

		#endregion

		private void frmMain_Load(object sender, EventArgs e)
		{
			dtg.CellClick += dtg_CellClick;
			DataGridViewConstructorList();
		}

		private void DataGridViewConstructorList()
		{
			try
			{
				if (dtg.Rows.Count > 0) dtg.Rows.Clear();
				string[] i = new string[Enum.GetValues(typeof(Col)).Length];
				foreach (var c in _controller.ListOfContacts)
				{
					i[(int)Col.ID] = c.Id.ToString();
					i[(int)Col.Name] = c.Name.ToString();
					i[(int)Col.Email] = c.Email.ToString();
					i[(int)Col.Phone] = c.Phone.ToString();
					i[(int)Col.Birthday] = c.Birth.ToShortDateString();
					i[(int)Col.Action] = "X";
					i[(int)Col.Edit] = "E";
					dtg.Rows.Add(i);
					dtg.Refresh();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, MessageBoxHelper.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				_currentProcess = CurrentProcess.Exception;
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			try
			{
				switch (_currentProcess)
				{
					case CurrentProcess.Init:
					case CurrentProcess.Exception:
						_newContact = new Contact(true);
						UnlockControls(false);
						break;
					case CurrentProcess.New:
						_user = MessageBox.Show(MessageBoxHelper.INSERT_CANCEL_QUESTION_MESSAGE,
							MessageBoxHelper.QUESTION_TITLE,
							MessageBoxButtons.YesNo, 
							MessageBoxIcon.Question);
						if (_user.Equals(DialogResult.No)) return;
						_newContact = new Contact(true);
						ClearData();
						UnlockControls(false);
						break;
					case CurrentProcess.Edition:
						_user = MessageBox.Show(MessageBoxHelper.UPDATE_CANCEL_QUESTION_MESSAGE,
							MessageBoxHelper.QUESTION_TITLE,
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question);
						if (_user.Equals(DialogResult.No)) return;
						_controller.CurrentId = "0";
						ClearData();
						UnlockControls(false);
						btnAdd.Text = "Add";
						break;
				}
				txtFullName.Focus();
				_currentProcess = CurrentProcess.New;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, MessageBoxHelper.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				_currentProcess = CurrentProcess.Exception;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_hasEmailException)
				{
					_message = string.Format(MessageBoxHelper.EXCEPTION_WRONG_EMAIL, txtEmail.Text);
					throw new EmptyFieldException(_message);
				}
				switch (_currentProcess)
				{
					case CurrentProcess.Exception:
						return;
					case CurrentProcess.New:
						if (string.IsNullOrWhiteSpace(_newContact.Name))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Full Name"));
						if (string.IsNullOrWhiteSpace(_newContact.Email))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Email"));
						if (string.IsNullOrWhiteSpace(_newContact.Phone))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Phone"));
						if (!_hasDate) _newContact.Birth = txtBirth.Value;
						_controller.CreateContact(_newContact);
						break;
					case CurrentProcess.Edition:
						if (string.IsNullOrWhiteSpace(_controller.CurrentContact.Name))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Full Name"));
						if (string.IsNullOrWhiteSpace(_controller.CurrentContact.Email))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Email"));
						if (string.IsNullOrWhiteSpace(_controller.CurrentContact.Phone))
							throw new EmptyFieldException(string.Format(MessageBoxHelper.EXCEPTION_EMPTY_FIELD, "Phone"));
						if (!_controller.UpdateContact().Equals(1))
						{
							_message = string.Format(MessageBoxHelper.EXCEPTION_UPDATE_CONTACT, _controller.CurrentContact.Name);
							throw new Exception(_message);
						}
						break;
				}
				DataGridViewConstructorList();
				ClearData();
				UnlockControls(true);
				_currentProcess = CurrentProcess.Init;
			}
			catch (EmptyFieldException efex)
			{
				MessageBox.Show(efex.Message, MessageBoxHelper.WARNING_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, MessageBoxHelper.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (_currentProcess.Equals(CurrentProcess.Edition)) btnAdd.Text = "Add";
				_currentProcess = CurrentProcess.Exception;
			}
		}

		private void dtg_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0) return;
				_rowIndex = e.RowIndex;
				switch ((Col)e.ColumnIndex)
				{
					case Col.Action:
						_message = string.Format(MessageBoxHelper.QUESTION_MESSAGE, FullName);
						_user = MessageBox.Show(_message, MessageBoxHelper.QUESTION_TITLE, 
							MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (_user.Equals(DialogResult.No)) return;
						if (_controller.DeleteContact(Id).Equals(1))
						{
							DataGridViewConstructorList();
						}
						ClearData();
						break;
					case Col.Edit:
						_controller.CurrentId = Id;
						PopulateData();
						_currentProcess = CurrentProcess.Edition;
						btnAdd.Text = "Update";
						UnlockControls(false);
						break;
					default:
						switch (_currentProcess)
						{
							case CurrentProcess.New:
								_user = MessageBox.Show(MessageBoxHelper.INSERT_CANCEL_QUESTION_MESSAGE,
									MessageBoxHelper.QUESTION_TITLE,
									MessageBoxButtons.YesNo,
									MessageBoxIcon.Question);
								if (_user.Equals(DialogResult.No)) return;
								_newContact = new Contact();
								ClearData();
								UnlockControls(true);
								_currentProcess = CurrentProcess.Init;
								break;
							case CurrentProcess.Edition:
								_user = MessageBox.Show(MessageBoxHelper.UPDATE_CANCEL_QUESTION_MESSAGE,
									MessageBoxHelper.QUESTION_TITLE,
									MessageBoxButtons.YesNo,
									MessageBoxIcon.Question);
								if (_user.Equals(DialogResult.No)) return;
								_controller.CurrentId = "0";
								ClearData();
								UnlockControls(true);
								btnAdd.Text = "Add";
								_currentProcess = CurrentProcess.Init;
								break;
						}
						_controller.CurrentId = Id;
						PopulateData();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, MessageBoxHelper.ERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
				_currentProcess = CurrentProcess.Exception;
			}
		}

		private void PopulateData()
		{
			txtFullName.Text = _controller.CurrentContact.Name.ToString().ToUpper();
			txtEmail.Text = _controller.CurrentContact.Email.ToString().ToUpper();
			txtPhone.Text = _controller.CurrentContact.Phone.ToString().ToUpper();
			txtBirth.Value = _controller.CurrentContact.Birth;
		}

		private void ClearData()
		{
			txtFullName.Clear();
			txtEmail.Clear();
			txtPhone.Clear();
			txtBirth.Value = DateTime.Now;
		}

		private void UnlockControls(bool value)
		{
			txtFullName.ReadOnly = value;
			txtEmail.ReadOnly = value;
			txtPhone.ReadOnly = value;
			txtBirth.Enabled = !value;
			btnAdd.Enabled = !value;
		}

	}
}
