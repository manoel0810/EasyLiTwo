using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Validations.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace EasyLiTwo.Database.Domain.Validations
{
    public class ClientValidation : IValidate
    {
        private readonly ClientEntity _clientEntity;

        public ClientValidation(ClientEntity entity)
        {
            _clientEntity = entity;
            Validate();
        }

        private void Validate()
        {
            if (_clientEntity != null)
            {
                if (_clientEntity.Code == Guid.Empty || _clientEntity.Code == null)
                    _clientEntity.PullNotification(new Notifications.Notification(nameof(_clientEntity.Code), "the prop [Guid] is required"));
                else if (string.IsNullOrWhiteSpace(_clientEntity.Username))
                    _clientEntity.PullNotification(new Notifications.Notification(nameof(_clientEntity.Username), "the prop [Username] is required"));
                else if (string.IsNullOrEmpty(_clientEntity.SHA))
                    _clientEntity.PullNotification(new Notifications.Notification(nameof(_clientEntity.SHA), "the prop [SHA] is required"));
                else if (DateTime.Now.Subtract(_clientEntity.Birth).Days < 360)
                    _clientEntity.PullNotification(new Notifications.Notification(nameof(_clientEntity.Birth), "the prop [Birth] must be more than one year"));
                else if (!string.IsNullOrWhiteSpace(_clientEntity.Email) && !IsValidEmail(_clientEntity.Email))
                    _clientEntity.PullNotification(new Notifications.Notification(nameof(_clientEntity.Email), "the prop [Email] was in wrong format"));

            }
            else
            {
                throw new ArgumentNullException(nameof(ClientEntity), "entity null");
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^([0-9a-zA-Z]+[-._+&])*[0-9a-zA-Z]+@([-0-9a-zA-Z]+[.])+[a-zA-Z]{2,6}$";
                return Regex.IsMatch(email, pattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsValid()
        {
            return _clientEntity.Notifications.Count == 0;
        }
    }
}
