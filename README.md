# async_await

## what does await do:

- 1 wait and validate the op for result
- 2 introduces a continuation which is code executed after async method, in original context(eg: UI thread, ex handling, ...)
- 3 diff between using await and ContinueWith is the ContinueWith in not back to the original context


## async await can:

using async and await in asp.net means the web server can handle other requests
using async and await in winform, wpf, can avoid the ui thread is blocked by some long time op


## best practices

Do Not

- never use async void unless it's event handler or delegate
- never block an async method by calling .Result or .Wait()

Do

- always use async and await together
- ayways return a Task from async method(not void!)
- always await an async method to validate the op
- always use async and await all the way up to the chain
