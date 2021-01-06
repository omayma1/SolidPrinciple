using System;

public class UserService
{
	public InsertUser(string username)
	{
        if (username == "admin")
            throw new InvalidOperationException();
        //Connect to database and insert new User
        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database. 
        //Send Email
        SmtpClient client = new SmtpClient("smtp.myhost.com");
        client.Send(new MailMessage()); //Send a welcome email. 
    }
}
}
