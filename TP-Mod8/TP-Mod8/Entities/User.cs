﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Mod8.Entities
{
    public class User
{
	private String login;
	private String password;

	public String Login
	{
		get { return login; }
		set { login = value; }
	}

	public String Password
	{
		get { return password; }
		set { password = value; }
	}

	public string Email { get; set; }
}
}
