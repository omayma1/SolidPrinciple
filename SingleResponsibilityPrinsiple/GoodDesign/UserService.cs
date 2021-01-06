using System;

public class UserService
{
    public InsertUser(string username)
    {
        if (username == "admin")
            throw new InvalidOperationException();

        _userService.Insert(...);

        _emailService.Send(...);
    }

}
