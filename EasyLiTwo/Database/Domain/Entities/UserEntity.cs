using EasyLiTwo.Database.Domain.Enums;
using EasyLiTwo.Database.Domain.Notifications;
using EasyLiTwo.Database.Domain.Validations;
using EasyLiTwo.Database.Domain.Validations.Interfaces;
using EasyLiTwo.Database.Output.DTOs;
using System.Collections.Generic;

namespace EasyLiTwo.Database.Domain.Entities
{
    public class UserEntity : IValidate
    {
        #region Internal Props
        readonly List<Notification> _notifications;
        #endregion

        public UserEntity(string username, string sha, string name, string email, UserType usertype, UserState userState)
        {
            Username = username;
            SHA = sha;
            Name = name;
            Email = email;
            UserType = usertype;
            UserState = userState;

            _notifications = new List<Notification>();
            //IsValid();
        }

        public UserEntity(UserDTO userDTO)
        {
            Username = userDTO.Username;
            SHA = userDTO.SHA;
            Name = userDTO.Name;
            Email = userDTO.Email;

            UserType = (UserType)userDTO.UserType;
            UserState = (UserState)userDTO.UserState;

            _notifications = new List<Notification>();
            //IsValid();
        }

        #region  External Props
        public string Username { get; set; }
        public string SHA { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public UserState UserState { get; set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;

        #endregion

        public void PullNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool IsValid()
        {
            return new LoginCreateValidation(this).CheckFields().IsValid();
        }

        public bool IsFree() => UserState == UserState.Free;
    }
}
