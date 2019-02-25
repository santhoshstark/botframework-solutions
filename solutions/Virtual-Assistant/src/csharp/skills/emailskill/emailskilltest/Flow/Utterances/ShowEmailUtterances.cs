﻿using EmailSkillTest.Flow.Strings;
using Luis;

namespace EmailSkillTest.Flow.Utterances
{
    public class ShowEmailUtterances : BaseTestUtterances
    {
        public ShowEmailUtterances()
        {
            this.Add(ReadMore, CreateIntent(ReadMore, intent: EmailLU.Intent.ReadAloud));
            this.Add(ShowEmails, CreateIntent(ShowEmails, intent: EmailLU.Intent.CheckMessages));
            this.Add(ShowEmailsFromTestRecipient, CreateIntent(
                ShowEmailsFromTestRecipient,
                intent: EmailLU.Intent.CheckMessages,
                senderName: new string[] { ContextStrings.TestRecipient }));
        }

        public static string ReadMore { get; } = "Read more";

        public static string ShowEmails { get; } = "Show Emails";

        public static string ShowEmailsFromTestRecipient { get; } = "Show Emails from" + ContextStrings.TestRecipient;
    }
}
