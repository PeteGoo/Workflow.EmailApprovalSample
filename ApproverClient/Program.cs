using System;

namespace ApproverClient {
    class Program {
        static void Main(string[] args) {
            var client = new ApprovalWorkflowService.ServiceClient();
            client.BeginApprovalProcess(new[] {
                                                  "approver1@foo.com", 
                                                  "approver2@foo.com", 
                                                  "approver3@foo.com"
                                              }, 
                                              "Holiday approval for Joe Bloggs from 2nd December to 12th January?", 
                                              "joe.bloggs@foo.com");

            Console.ReadKey(false);
        }
    }
}
