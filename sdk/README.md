## Fable bindings for Azure SDKs

`ts2fable` can't currently handle the exports structure most MS libraries use and the generated bindings require a bit of tweaking, so the process is:
- extract all the APIs - single file per API
- generate the bindings on per-API basis as needed
- tweak the generated bindings

Commit only the bindings.

### Extraction
Extract-API package is configured once, called for each API in the `extract.js` and drop the resulting `.d.ts` in `temp` folder.
Adjust `packages` array in `extract.js` to generate bindings for a different API, specifying the name for the bundle, the entry-point and, optionally, any dependencies to bundle along.
Keep in mind that the generated bundle is just for `ts2fable` to work correcty and all the imports still need to come from the corresponding JS package.

### F# Generation
`ts2fable` is called per-API to produce single import file per SDK. Tweak as needed.
See [this issue](https://github.com/fable-compiler/ts2fable/issues/344) that affects a lot of generated types in Azure SDK, the workaround is to manually adjust the generated types.
