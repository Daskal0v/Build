﻿namespace Build.Shared.Infrastructure.Interfaces;

using System.Threading.Tasks;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}
