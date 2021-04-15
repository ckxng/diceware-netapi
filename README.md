diceware-netapi
===============

This project demonstrates a Diceware passphrase generator as an ASP.NET Core API.

## Usage

Open the project in Visual Studio 2019 and run the project using one of the 
configured build targets.

Example:

    https://localhost:44317/generate?sep=^&words=4
    
    reshape^acre^october^goofball

## Observability

Telemetry is set to Jaeger on the local system, if it is running.

Using this data, we are able to make observations such as the following:

- The first API call typically takes twice a long to complete
  - The bootstrapping period for the first API call takes 100x longer than subsequent calls
  - The first database lookup of the first API call takes 25x longer than the first database lookup in subsequent calls
- Even in subsequent calls, the first database lookup of the call takes 17 times longer than subsequent calls within the same request
- The dice roll itself is nealy instantaneous

Based on this, if we were to create an in-memory cache of the word database, we could expect to substancially speed up the responsiveness of the application.  Without using an in-memory cache, we could also speed up execution by a small amount using a singleton database object that doesn't need to be re-initialized with each subsequent API call.

## Author

[Cameron King](http://cameronking.me)

## License

This software is released under the ISC License.

See `LICENSE.txt` file for details.
