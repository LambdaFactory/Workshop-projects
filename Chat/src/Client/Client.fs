module Client

//The client for our chat application.
//It should supports several commands:
// - connect channel_name -> connects to the channel with given name, should print out error message if channel doesn't exist
// - send msg -> sends message to connected channel, should print out error message if not conected or channel stopped existing
// - get -> gets all messages from given channel that happend since last `get` command, should print out error message if not conected or channel stopped existing
// - create channel_name -> creates new channel with given name, should print out error message if channel with such name already exist
// - disconnect channel_name -> disconnects from the channel, should print out error message if not connected to any channel
// - remove channel_name -> deletes channel
// - exit -> quits the client

//The information about channels (list of existing channels, list of messages in channel is stored in server part)
// client just needs to track information about itself - to which channel is it connected, when it last time called `get` etc.

//Client should save all commands that were executed in log file.

// Task 1 - Create domain - types representing state of the client and type representing commands.
// Task 2 - Create functions that convert input string to the command type.
//          Create function that converts command type to `Common.Message` type. Use Active patterns
// Task 3 - Create recursive function that will ask users for input (`Console.ReadLine()`) until someone executes `exit` command
// Task 4 - Create non-blocking system for writting commands to history log. Use MailboxProcessor.
//          Remember to use `Common.ILogger` type to make sure that implementation of history system is testable.
// Task 5 - Create async method to send instances of `Common.Message` to the server (`localhost:8080`).
//          Helper functions for serialization are in `Common.Serializer` module.
//          Use standard .Net classes and functions for sending Http requests
//          Server returns `Common.Message` in the body of response that contains information whether command was sucessfully executed
// Task 6 (Optional) - Add browsing history of send commands with up/down arrors
// Task 7 (Optional) - Set initial state of the client using existing history file from previous run.

[<EntryPoint>]
let main argv =
    let appId = argv.[0] //unique client Id that can be used to create log / history file name


    printfn "%A" argv
    0 // return an integer exit code
