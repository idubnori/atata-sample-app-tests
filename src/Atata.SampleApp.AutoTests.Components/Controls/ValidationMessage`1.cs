﻿namespace Atata.SampleApp.AutoTests
{
    [ControlDefinition("div[contains(concat(' ', normalize-space(@class), ' '), ' has-error ')]//span[contains(concat(' ', normalize-space(@class), ' '), ' help-block ')]", ComponentTypeName = "validation message")]
    public class ValidationMessage<TOwner> : Text<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public new FieldVerificationProvider<string, ValidationMessage<TOwner>, TOwner> Should =>
            new FieldVerificationProvider<string, ValidationMessage<TOwner>, TOwner>(this);
    }
}
