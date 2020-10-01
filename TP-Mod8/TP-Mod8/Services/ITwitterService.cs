using System;
using System.Collections.Generic;
using System.Text;
using TP_Mod8.Entities;

namespace TP_Mod8.Services
{
    public interface ITwitterService
{
    Boolean Authenticate(User user);
    List<Tweet> Tweets { get; }
}
}
