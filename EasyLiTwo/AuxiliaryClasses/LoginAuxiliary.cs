using EasyLiTwo.Database.Domain.Notifications;
using EasyLiTwo.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace EasyLiTwo.AuxiliaryClasses
{
    public class LoginAuxiliary : IAuditable
    {
        #region Internal Props
        readonly List<Notification> _notifications;
        #endregion

        private string _username;
        private string _password;
        private string _HASH = string.Empty;
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public string GetHash => _HASH;

        public LoginAuxiliary(string username, string password)
        {
            _username = username;
            _password = password;

            _notifications = new List<Notification>();
            Validate();

            if (IsValid())
                CalculateHash();
        }

        public void Reset(string username, string password)
        {
            _username = username;
            _password = password;
            _HASH = string.Empty;

            _notifications.Clear();
            Validate();

            if (IsValid())
                CalculateHash();
        }

        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(_username))
                _notifications.Add(new Notification(nameof(_username), "Parâmetro de username inválido"));

            if (string.IsNullOrWhiteSpace(_password))
                _notifications.Add(new Notification(nameof(_password), "Parâmetro de password inválido"));
        }

        private string BytesToString(byte[] Bytes)
        {
            string Partial = "";
            foreach (byte b in Bytes)
                Partial += b.ToString("X2");

            return Partial;
        }

        private void CalculateHash()
        {
            using (var service = System.Security.Cryptography.SHA512.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes($"{_username}::{_password}");
                var hash = BytesToString(service.ComputeHash(bytes));
                _HASH = hash;
            }
        }

        public bool IsValid()
        {
            return _notifications.Count == 0;
        }

        public void PullNotification(Notification notification)
        {
            _notifications.Add(notification);
        }
    }
}
