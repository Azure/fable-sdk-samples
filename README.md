# Azure SDK bindings generation and samples for [Fable compiler](https://fable.io)

Sample Fable bindings generation for Azure SDKs and a sample [elmish](https://elmish.github.io/) application that uses them.

### Pre-requisites
- .NET SDK 3.1
- [`node`](https://nodejs.org/)
- [`yarn`](https://yarnpkg.com/)

### Building and running
- Check out the SDK and frontend READMEs
- `dotnet tool restore` (once)
- `dotnet fake build` to build or
- `dotnet fake built -t start` to start the local server, then open `http://localhost:8090` in a browser to open the sample


## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
