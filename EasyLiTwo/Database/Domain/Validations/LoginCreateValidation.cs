using EasyLiTwo.Database.Domain.Entities;
using EasyLiTwo.Database.Domain.Notifications;
using EasyLiTwo.Database.Domain.Validations.Interfaces;

namespace EasyLiTwo.Database.Domain.Validations
{
    public class LoginCreateValidation : IValidate
    {
        private readonly UserEntity _user;
        public LoginCreateValidation(UserEntity user)
        {
            _user = user;
        }

        public LoginCreateValidation CheckFields()
        {
            if (string.IsNullOrWhiteSpace(_user.Name) || _user.Name.Length < 10)
                _user.PullNotification(new Notification(nameof(_user.Name), "O campo [NOME] é obrigatório"));

            if (string.IsNullOrWhiteSpace(_user.Username))
                _user.PullNotification(new Notification(nameof(_user.Username), "O campo [USERNAME] é obrigatório"));

            if (string.IsNullOrWhiteSpace(_user.SHA))
                _user.PullNotification(new Notification(nameof(_user.SHA), "o HASH de autenticação deve ser calculado e passado para a entidade"));


            return this;
        }

        public bool IsValid()
        {
            return _user.Notifications.Count == 0;
        }
    }
}
