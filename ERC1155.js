const Web3 = require('web3')
const web3 = new Web3('https://mainnet.infura.io/v3/c5b171b230fa4d48b3be4f766594dd1c')
const abi=[{"constant":false,"inputs":[{"name":"target","type":"address"}],"name":"addAuthorizedAddress","outputs":[],"payable":false,"stateMutability":"nonpayable","type":"function"},{"constant":true,"inputs":[{"name":"","type":"uint256"}],"name":"authorities","outputs":[{"name":"","type":"address"}],"payable":false,"stateMutability":"view","type":"function"},{"constant":false,"inputs":[{"name":"target","type":"address"}],"name":"removeAuthorizedAddress","outputs":[],"payable":false,"stateMutability":"nonpayable","type":"function"},{"constant":true,"inputs":[],"name":"owner","outputs":[{"name":"","type":"address"}],"payable":false,"stateMutability":"view","type":"function"},{"constant":false,"inputs":[{"name":"target","type":"address"},{"name":"index","type":"uint256"}],"name":"removeAuthorizedAddressAtIndex","outputs":[],"payable":false,"stateMutability":"nonpayable","type":"function"},{"constant":false,"inputs":[{"name":"assetData","type":"bytes"},{"name":"from","type":"address"},{"name":"to","type":"address"},{"name":"amount","type":"uint256"}],"name":"transferFrom","outputs":[],"payable":false,"stateMutability":"nonpayable","type":"function"},{"constant":true,"inputs":[],"name":"getProxyId","outputs":[{"name":"","type":"bytes4"}],"payable":false,"stateMutability":"pure","type":"function"},{"constant":true,"inputs":[{"name":"","type":"address"}],"name":"authorized","outputs":[{"name":"","type":"bool"}],"payable":false,"stateMutability":"view","type":"function"},{"constant":true,"inputs":[],"name":"getAuthorizedAddresses","outputs":[{"name":"","type":"address[]"}],"payable":false,"stateMutability":"view","type":"function"},{"constant":false,"inputs":[{"name":"newOwner","type":"address"}],"name":"transferOwnership","outputs":[],"payable":false,"stateMutability":"nonpayable","type":"function"},{"anonymous":false,"inputs":[{"indexed":true,"name":"target","type":"address"},{"indexed":true,"name":"caller","type":"address"}],"name":"AuthorizedAddressAdded","type":"event"},{"anonymous":false,"inputs":[{"indexed":true,"name":"target","type":"address"},{"indexed":true,"name":"caller","type":"address"}],"name":"AuthorizedAddressRemoved","type":"event"}]
const address='0x7EeFBd48FD63d441Ec7435D024EC7c5131019ADd'

const contract =new web3.eth.Contract(abi,address)

contract.getPastEvents(
    'AllEvents',
    {
        fromBlock: 8262110 ,
        toBlock:'latest'
    },
    (err,events) => { console.log(events)}
)   