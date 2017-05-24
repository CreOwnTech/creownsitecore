module.exports = function () {
  var instanceRoot = "D:\\inetpub\\CreOwnSitecore";
  var config = {
    websiteRoot: instanceRoot + "\\Website",
    sitecoreLibraries: instanceRoot + "\\Website\\bin",
    licensePath: instanceRoot + "\\Data\\license.xml",
    solutionName: "CreOwn",
    buildConfiguration: "Debug",
    buildPlatform: "Any CPU",
    buildToolsVersion: 14.0, //change to 15.0 for VS2017 support
    publishPlatform: "AnyCpu",
    runCleanBuilds: false
  };
  return config;
}
