namespace EasyLiTwo.Database.Domain.Enums
{
    public enum UserType : int
    {
        Default = 0,
        Maintence = 1,
        Administrator = 2,
    }

    public enum UserState : int
    {
        Blocked = 0,
        Free = 1,
    }
}
