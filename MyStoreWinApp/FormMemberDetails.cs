using BusinessObject;
using DataAccess.Repository;
using System.Net.Mail;

namespace MyStoreWinApp
{
    public partial class FormMemberDetails : Form
    {
        public bool IsUpdateMode { get; init; }
        private IMemberRepository MemberRepository { get; init; }
        public bool IsCreateMode { get; init; }
        public MemberObject? MemberParam { get; init; }
        public FormMemberDetails(IMemberRepository memberRepository)
        {
            MemberRepository = memberRepository;
            InitializeComponent();
        }

        private void FormMemberDetails_Load(object sender, EventArgs e)
        {
            buttonCreate.Visible = IsCreateMode;

            if (IsUpdateMode && MemberParam != null)
            {
                buttonUpdate.Visible = IsUpdateMode;
                textBoxMemberId.Text = MemberParam.MemberId.ToString();
                textBoxMemberId.Enabled = false;
                textBoxMemberName.Text = MemberParam.MemberName;
                textBoxPassword.Text = MemberParam.Password;
                textBoxEmail.Text = MemberParam.Email;
                textBoxCity.Text = MemberParam.City;
                textBoxCountry.Text = MemberParam.Country;
            }
        }
        private bool isValidEmail(String email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private MemberObject GetCurrentMemberObject()
        {
            if (!int.TryParse(textBoxMemberId.Text, out var id))
            {
                throw new FormatException("Member ID must be a number.");
            }

            string name = textBoxMemberName.Text.Trim();
            if (name.Length == 0)
            {
                throw new FormatException("Member name is not valid!");
            }
            string password = textBoxPassword.Text.Trim();
            if (password.Length == 0)
            {
                throw new FormatException("Password is not valid!");
            }

            string email = textBoxEmail.Text.Trim();
            if (!isValidEmail(email))
            {
                throw new FormatException("Email is not valid!");
            }
            string city = textBoxCity.Text.Trim();
            if (city.Length == 0)
            {
                throw new FormatException("City is not valid!");
            }
            string country = textBoxCountry.Text.Trim();
            if (country.Length == 0)
            {
                throw new FormatException("Country is not valid!");
            }

            return new MemberObject()
            {
                MemberId = id,
                Password = password,
                MemberName = name,
                Email = email.ToLower(),
                City = city,
                Country = country
            };
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetCurrentMemberObject();
                bool isCreatedSuccess = MemberRepository.AddMember(member);
                if (isCreatedSuccess)
                {
                    MessageBox.Show(@"Create member success.", @"Create Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Create member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Create member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetCurrentMemberObject();
                bool isUpdatedSuccess = MemberRepository.UpdateMember(member);
                if (isUpdatedSuccess)
                {
                    MessageBox.Show(@"Updated member success.", @"Update Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, @"Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Create member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
