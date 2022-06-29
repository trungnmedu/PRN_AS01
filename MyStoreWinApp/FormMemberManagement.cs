using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class FormMemberManagement : Form
    {
        private IMemberRepository MemberRepository { get; init; }
        private readonly BindingSource _bindingSource = new BindingSource();

        private IEnumerable<MemberObject>? _listMembers;
        private IEnumerable<MemberObject>? _searchResult;
        private List<string>? _cityFilter;
        private List<string>? _countryFilter;
        public FormMemberManagement(IMemberRepository memberRepository)
        {
            MemberRepository = memberRepository;
            InitializeComponent();
        }

        private void FormMemberManagement_Load(object sender, EventArgs e)
        {
            FormInitLoading();
        }

        private void FormInitLoading()
        {
            ToggleEnableTextBoxState(false);
            ToggleEnableAllGroupBoxState(false);
            ToggleEnableDeleteButton(false);
            ToggleEnableNewButton(true);
            LoadFullListMembers();
            dataGridViewMembers.AutoGenerateColumns = false;
            if (_bindingSource.List.Count > 0)
            {
                ToggleEnableAllGroupBoxState(true);
                ToggleEnableDeleteButton(true);

                _cityFilter = (from member in _listMembers select member.City).Distinct().ToList();
                _cityFilter.Insert(0, "");
                comboBoxFilterByCity.DataSource = _cityFilter;

                _countryFilter = (from member in _listMembers select member.Country).Distinct().ToList();
                _countryFilter.Insert(0, "");
                comboBoxFilterByCountry.DataSource = _countryFilter;
            }
        }

        private void ReloadData()
        {
            LoadFullListMembers();
            if (_listMembers != null && _listMembers.Any())
            {
                ToggleEnableAllGroupBoxState(true);
                ToggleEnableDeleteButton(true);
                ToggleEnableNewButton(true);
                _bindingSource.DataSource = from member in _listMembers orderby member.MemberName descending select member;

                _cityFilter = (from member in _listMembers select member.City).Distinct().ToList();
                _cityFilter.Insert(0, "");
                comboBoxFilterByCity.DataSource = _cityFilter;

                _countryFilter = (from member in _listMembers select member.Country).Distinct().ToList();
                _countryFilter.Insert(0, "");
                comboBoxFilterByCountry.DataSource = _countryFilter;
            }
            else
            {
                ToggleEnableAllGroupBoxState(false);
                ToggleEnableDeleteButton(false);
            }
        }

        private void LoadFullListMembers()
        {
            dataGridViewMembers.DataSource = null;
            textBoxMemberId.DataBindings.Clear();
            textBoxMemberCity.DataBindings.Clear();
            textBoxMemberCountry.DataBindings.Clear();
            textBoxMemberPassword.DataBindings.Clear();
            textBoxMemberName.DataBindings.Clear();
            textBoxMemberEmail.DataBindings.Clear();

            _listMembers = MemberRepository.GetMembersList();
            _listMembers = from member in _listMembers orderby member.MemberName descending select member;
            _bindingSource.DataSource = _listMembers;

            dataGridViewMembers.DataSource = _bindingSource;
            textBoxMemberId.DataBindings.Add("Text", _bindingSource, "MemberId");
            textBoxMemberCity.DataBindings.Add("Text", _bindingSource, "City");
            textBoxMemberCountry.DataBindings.Add("Text", _bindingSource, "Country");
            textBoxMemberPassword.DataBindings.Add("Text", _bindingSource, "Password");
            textBoxMemberName.DataBindings.Add("Text", _bindingSource, "MemberName");
            textBoxMemberEmail.DataBindings.Add("Text", _bindingSource, "Email");
        }

        private MemberObject? GetCurrentMemberDisplay()
        {
            try
            {
                int id = int.Parse(textBoxMemberId.Text);
                return MemberRepository.SearchMemberById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        private void ToggleEnableDeleteButton(bool state)
        {
            buttonDelete.Enabled = state;
        }

        private void ToggleEnableNewButton(bool state)
        {
            buttonNew.Enabled = state;
        }

        private void ToggleEnableAllGroupBoxState(bool state)
        {
            groupBoxFilterByCountry.Enabled = state;
            groupBoxSearchBy.Enabled = state;
            groupSearchInput.Enabled = state;
        }

        private void ToggleEnableTextBoxState(bool state)
        {
            textBoxMemberCity.Enabled = state;
            textBoxMemberCountry.Enabled = state;
            textBoxMemberId.Enabled = state;
            textBoxMemberPassword.Enabled = state;
            textBoxMemberName.Enabled = state;
            textBoxMemberEmail.Enabled = state;
        }

        private IEnumerable<MemberObject> SearchMemberById(int id)
        {
            return from member in _listMembers where (member.MemberId == id) orderby member.MemberName descending select member;
        }

        private IEnumerable<MemberObject> SearchMemberByName(string name)
        {
            return from member in _listMembers where (member.MemberName.ToLower().Contains(name.ToLower())) orderby member.MemberName descending select member;
        }

        private IEnumerable<MemberObject> SearchMemberByCountryFilter(string? country)
        {
            return from member in _searchResult where (member.Country.Equals(country)) orderby member.MemberName descending select member;
        }

        private IEnumerable<MemberObject> SearchMemberByCityFilter(string? city)
        {
            return from member in _searchResult where (member.City.Equals(city)) orderby member.MemberName descending select member;
        }


        private void SearchAccount()
        {
            try
            {
                string keyword = textBoxSearchKeyword.Text;

                if (radioButtonSearchById.Checked)
                {
                    _searchResult = SearchMemberById(int.Parse(keyword));
                }

                if (radioButtonSearchByName.Checked)
                {

                    _searchResult = SearchMemberByName(keyword);
                }

                if (comboBoxFilterByCity.SelectedItem?.ToString()?.Length > 0)
                {
                    _searchResult = SearchMemberByCityFilter(comboBoxFilterByCity.SelectedItem.ToString());
                }

                if (comboBoxFilterByCountry.SelectedItem?.ToString()?.Length > 0)
                {
                    _searchResult = SearchMemberByCountryFilter(comboBoxFilterByCountry.SelectedItem.ToString());
                }

                if (_searchResult != null && _searchResult.Any())
                {
                    _bindingSource.DataSource = _searchResult;
                }
                else
                {
                    _bindingSource.DataSource = _listMembers?.ToList();
                    _bindingSource.Clear();
                    MessageBox.Show(@"No result", @"Search Members", MessageBoxButtons.OK);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Member Id must is a number.", @"Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(@"System busy can't search now. Try again!", @"Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            MemberObject? currentMember = GetCurrentMemberDisplay();

            if (currentMember == null)
            {
                MessageBox.Show(@"Delete failed!", @"Delete member", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MemberRepository.DeleteMember(currentMember.MemberId))
            {
                MessageBox.Show(@"Delete success", @"Delete member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadData();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void dataGridViewMembers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FormMemberDetails formMemberDetails = new FormMemberDetails(MemberRepository)
            {
                IsUpdateMode = true,
                MemberParam = GetCurrentMemberDisplay()
            };
            if (formMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullListMembers();
                ReloadData();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormMemberDetails formMemberDetails = new FormMemberDetails(MemberRepository)
            {
                IsCreateMode = true
            };
            if (formMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullListMembers();
                ReloadData();
            }
        }

        private void comboBoxFilterByCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void comboBoxFilterByCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {

            comboBoxFilterByCity.SelectedIndex = 0;
            comboBoxFilterByCountry.SelectedIndex = 0;
            textBoxSearchKeyword.Text = String.Empty;
            _bindingSource.DataSource = _listMembers;
        }
    }
}
