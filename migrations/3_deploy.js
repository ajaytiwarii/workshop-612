const Migrations = artifacts.require("bewbank");

module.exports = function (deployer) {
  deployer.deploy(Migrations);
};