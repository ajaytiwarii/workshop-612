using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Smartcontract.Contracts.abc.ContractDefinition;

namespace Smartcontract.Contracts.abc
{
    public partial class AbcService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, AbcDeployment abcDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<AbcDeployment>().SendRequestAndWaitForReceiptAsync(abcDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, AbcDeployment abcDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<AbcDeployment>().SendRequestAsync(abcDeployment);
        }

        public static async Task<AbcService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, AbcDeployment abcDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, abcDeployment, cancellationTokenSource);
            return new AbcService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public AbcService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AddRequestAsync(AddFunction addFunction)
        {
             return ContractHandler.SendRequestAsync(addFunction);
        }

        public Task<string> AddRequestAsync()
        {
             return ContractHandler.SendRequestAsync<AddFunction>();
        }

        public Task<TransactionReceipt> AddRequestAndWaitForReceiptAsync(AddFunction addFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addFunction, cancellationToken);
        }

        public Task<TransactionReceipt> AddRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<AddFunction>(null, cancellationToken);
        }

        public Task<BigInteger> GetValueofaQueryAsync(GetValueofaFunction getValueofaFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofaFunction, BigInteger>(getValueofaFunction, blockParameter);
        }

        
        public Task<BigInteger> GetValueofaQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofaFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetValueofbQueryAsync(GetValueofbFunction getValueofbFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofbFunction, BigInteger>(getValueofbFunction, blockParameter);
        }

        
        public Task<BigInteger> GetValueofbQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofbFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetValueofcQueryAsync(GetValueofcFunction getValueofcFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofcFunction, BigInteger>(getValueofcFunction, blockParameter);
        }

        
        public Task<BigInteger> GetValueofcQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetValueofcFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> MulRequestAsync(MulFunction mulFunction)
        {
             return ContractHandler.SendRequestAsync(mulFunction);
        }

        public Task<string> MulRequestAsync()
        {
             return ContractHandler.SendRequestAsync<MulFunction>();
        }

        public Task<TransactionReceipt> MulRequestAndWaitForReceiptAsync(MulFunction mulFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mulFunction, cancellationToken);
        }

        public Task<TransactionReceipt> MulRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<MulFunction>(null, cancellationToken);
        }

        public Task<string> SubRequestAsync(SubFunction subFunction)
        {
             return ContractHandler.SendRequestAsync(subFunction);
        }

        public Task<string> SubRequestAsync()
        {
             return ContractHandler.SendRequestAsync<SubFunction>();
        }

        public Task<TransactionReceipt> SubRequestAndWaitForReceiptAsync(SubFunction subFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(subFunction, cancellationToken);
        }

        public Task<TransactionReceipt> SubRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<SubFunction>(null, cancellationToken);
        }
    }
}
