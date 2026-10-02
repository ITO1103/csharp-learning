// 省略可能: テスト対象の型として型パラメーターを使用する

ShowConfidentialBatchHandling();

static void ShowConfidentialBatchHandling()
{
    // 型を配列に入れる
    object[] incomingRequests = [new BillingQuestion(), new ConfidentialRequest()];
    // 配列の中にConfidentialRequest型が含まれているか確認する
    bool requiresConfidentialHandling =
        ContainsRequestOfType<ConfidentialRequest>(incomingRequests);

    Console.WriteLine(requiresConfidentialHandling
        ? "Send the entire batch to confidential handling."
        : "Send the batch to standard handling.");
}

static bool ContainsRequestOfType<TRequest>(IEnumerable<object> requests)
{
    foreach (object request in requests)
    {
        if (request is TRequest) // requestがTRequest型ならtrueを返す
        {
            return true;
        }
    }

    return false; // 1つもTRequest型が無い場合
}

abstract class SupportRequest()
{
    
}

class PasswordResetRequest : SupportRequest
{
    
}

class BillingQuestion : SupportRequest
{
    
}

class ConfidentialRequest : SupportRequest
{
    
}