const Web3 = require('web3')
const web3 = new Web3('https://mainnet.infura.io/v3/c5b171b230fa4d48b3be4f766594dd1c')
const abi=[{"anonymous":false,"inputs":[{"indexed":true,"internalType":"address","name":"token","type":"address"}],"name":"ERC721ControlledCreated","type":"event"},{"inputs":[{"internalType":"string","name":"name","type":"string"},{"internalType":"string","name":"symbol","type":"string"},{"internalType":"string","name":"baseURI","type":"string"}],"name":"createERC721Controlled","outputs":[{"internalType":"contract ERC721Controlled","name":"","type":"address"}],"stateMutability":"nonpayable","type":"function"}]
const address='0x4E869b3A0978fA61DAbd7Da8F9B272AADc745Fb3'

const contract =new web3.eth.Contract(abi,address)

contract.getPastEvents(
    'AllEvents',
    {
        fromBlock: 11428875 ,
        toBlock:'latest'
    },
    (err,events) => { console.log(events)}
)   