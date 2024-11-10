using Duck_Mail.Data;
using Duck_Mail.Models;

namespace Duck_Mail.Repositories.Impl;

public class EmailTemplateRepository(DatabaseContext context) : Repository<EmailTemplate>(context), IEmailTemplateRepository
{ }