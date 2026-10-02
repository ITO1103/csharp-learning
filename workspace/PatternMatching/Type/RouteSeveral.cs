// 複数の種類をルーティングする

var test = new PasswordResetRequest();
Console.WriteLine(RouteRequest(test));

static string RouteRequest(object request) =>
    request switch // 型で分ける
    {
        PasswordResetRequest => "Identity queue",
        BillingQuestion => "Billing queue",
        SupportRequest => "General support queue",
        _ => "Intake queue"
    };

abstract class SupportRequest()
{
    
}

class PasswordResetRequest : SupportRequest
{
    
}

class BillingQuestion : SupportRequest
{
    
}