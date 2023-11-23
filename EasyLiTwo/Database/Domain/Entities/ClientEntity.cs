using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Domain.Notifications;
using EasyLiTwo.Database.Domain.Validations;
using EasyLiTwo.Database.Domain.Validations.Interfaces;
using EasyLiTwo.Database.Output.DTOs;
using System;
using System.Collections.Generic;

namespace EasyLiTwo.Database.Domain.Entities
{
    public class ClientEntity : IValidate
    {
        #region Internal Props
        readonly List<Notification> _notifications;
        #endregion

        public ClientEntity(Guid guid, string username, string email, DateTime birth, string sha, DateTime regDate, UserState state)
        {
            Code = guid;
            Username = username;
            Email = email;
            Birth = birth;
            SHA = sha;
            Reg = regDate;
            UserState = state;

            _notifications = new List<Notification>();
        }

        public ClientEntity(ClientDTO clientDTO)
        {
            Username = clientDTO.Name;
            Email = clientDTO.Email;
            Birth = clientDTO.Birth;
            SHA = clientDTO.SHA;
            Reg = clientDTO.RegDate;
            UserState = (UserState)clientDTO.Status;
        }

        #region  External Props
        public Guid Code { get; set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string SHA { get; private set; }
        public DateTime Birth { get; private set; }
        public DateTime Reg { get; private set; }
        public UserState UserState { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        #endregion

        public bool IsValid()
        {
            return new ClientValidation(this).IsValid();
        }

        public void PullNotification(Notification notification)
        {
            _notifications.Add(notification);
        }
    }
}
