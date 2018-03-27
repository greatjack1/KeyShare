# Key Share

A simple and easy to use platform allowing you to send and share small amounts of data between people and applications with zero configuration.

## Getting Started

To get started you can use the pre hosted version at https://keyshare.herokuapp.com Or you can host this app yourself on any cloud provider that supports asp.net core.

### Usage

Since the goal of this platform was to remain simple and easy to use, their are two requests that can be made.

1. Storing a value, to store a value just make a request to https://keyshare.herokuapp.com/keys/storevalue passing in three parameters. 1 - Key - The key for the value to store, 2 - Secret - a secret value that is required to edit this value and to retrieve the value, 3 - Value - the value to store for the specified Key. A full sample request would look like this https://keyshare.herokuapp.com/keys/storevalue?key=projectName&secret=secret123&value=keyshare

2. Retrieving a value, to retrieve a value just make a request to https://keyshare.herokuapp.com/keys/getvalue passing in two parameters. 1 - Key - The key of the value that you want to retrieve, 2 - Secret - The secret that you used when you submitted the original value. A sample request would look like this https://keyshare.herokuapp.com/keys/getvalue?key=projectName&secret=secret123


## Authors

Yaakov from the wyre corp
