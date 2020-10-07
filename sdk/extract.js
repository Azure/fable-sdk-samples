const path = require("path");
const {
  Extractor,
  ExtractorConfig,
  ExtractorResult
} = require('@microsoft/api-extractor');

const apiExtractorJsonPath ='api-extractor.json';
const node_modules = path.join(__dirname, "../node_modules");

// Load and parse the api-extractor.json file
const extractorConfig = ExtractorConfig.loadFileAndPrepare(apiExtractorJsonPath);
const packages = [
    { name: "msal", entrypoint: "@azure/msal-browser/dist/src/index.d.ts", include: ["@azure/msal-common"] },
    { name: "msrest", entrypoint: "@azure/ms-rest-azure-js/es/lib/msRestAzure.d.ts", include: ["@azure/ms-rest-js"] },
    { name: "graph", entrypoint: "@azure/graph/esm/graphRbacManagementClient.d.ts", include: [] }
];

for(const package of packages) {
    console.log("Extracting: ", package.name);
    // Invoke API Extractor
    const extractorResult = Extractor.invoke(
        {...extractorConfig,
         ...{
            mainEntryPointFilePath: path.join(node_modules, package.entrypoint),
            bundledPackages: package.include,
            untrimmedFilePath: `temp/fable-azure-${package.name}.d.ts`
        }}, { localBuild: true });

    if (extractorResult.succeeded) {
        console.error(`${package.name} extracted.`);
        process.exitCode = 0;
    } else {
        console.error(`Extraction on ${package.name} completed with ${extractorResult.errorCount} errors`
            + ` and ${extractorResult.warningCount} warnings`);
        process.exitCode = 1;
    }
}