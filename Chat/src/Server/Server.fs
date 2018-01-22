module Server

open Common

//TASK 1 - Create domain - type representing events that can happen, possible messages to MailboxProcessors, current state etc.
//TASK 2 - Implement parser functions that converts `Common.Message` into your domain events
//TASK 2 - Implement MailboxProcessor representing single chat channel
//TASK 3 - Implement MailboxProcessor representing state of whole server and responsible for creating and closing channels
//TASK 4 - Implemtnt logging system. Use yet-another-mailbox-processor and `Common.ILogger`
//TASK 5 - Implement message handler that takes `Common.Message` as an input and
//         returns `Common.Message` containg info about success / failure of operation as a outup
//TASK 6 (OPTIONAL) - Set initial state of the client using existing history file from previous run.
//TASK 7 (OPTIONAL) - Add command line interface to server app, allowing to ask it
//                    for list of channels, number of connected people etc. Use `startWebServerAsync` to start server without blocking.

let handleMessage (input : Message) : Message =
    {Type ="Not handled"; Content = ""}