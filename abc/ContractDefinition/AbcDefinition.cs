using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Smartcontract.Contracts.abc.ContractDefinition
{


    public partial class AbcDeployment : AbcDeploymentBase
    {
        public AbcDeployment() : base(BYTECODE) { }
        public AbcDeployment(string byteCode) : base(byteCode) { }
    }

    public class AbcDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405260096000556009600155600060025534801561001f57600080fd5b506101768061002f6000396000f3fe608060405234801561001057600080fd5b50600436106100625760003560e01c806349235ee5146100675780634f2be91f1461007d57806358931c46146100875780638513c9801461008f578063c54124be14610097578063e3e733991461009f575b600080fd5b6002545b60405190815260200160405180910390f35b6100856100a7565b005b6100856100bc565b60015461006b565b6100856100cc565b60005461006b565b6001546000546100b791906100dc565b600255565b6001546000546100b791906100f4565b6001546000546100b79190610113565b600082198211156100ef576100ef61012a565b500190565b600081600019048311821515161561010e5761010e61012a565b500290565b6000828210156101255761012561012a565b500390565b634e487b7160e01b600052601160045260246000fdfea264697066735822122074a5bfb2b4bf190447a8994c4da553016c5c9cf29feabc212a12f49d49aa69e464736f6c63430008060033";
        public AbcDeploymentBase() : base(BYTECODE) { }
        public AbcDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AddFunction : AddFunctionBase { }

    [Function("add")]
    public class AddFunctionBase : FunctionMessage
    {

    }

    public partial class GetValueofaFunction : GetValueofaFunctionBase { }

    [Function("getValueofa", "uint256")]
    public class GetValueofaFunctionBase : FunctionMessage
    {

    }

    public partial class GetValueofbFunction : GetValueofbFunctionBase { }

    [Function("getValueofb", "uint256")]
    public class GetValueofbFunctionBase : FunctionMessage
    {

    }

    public partial class GetValueofcFunction : GetValueofcFunctionBase { }

    [Function("getValueofc", "uint256")]
    public class GetValueofcFunctionBase : FunctionMessage
    {

    }

    public partial class MulFunction : MulFunctionBase { }

    [Function("mul")]
    public class MulFunctionBase : FunctionMessage
    {

    }

    public partial class SubFunction : SubFunctionBase { }

    [Function("sub")]
    public class SubFunctionBase : FunctionMessage
    {

    }



    public partial class GetValueofaOutputDTO : GetValueofaOutputDTOBase { }

    [FunctionOutput]
    public class GetValueofaOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetValueofbOutputDTO : GetValueofbOutputDTOBase { }

    [FunctionOutput]
    public class GetValueofbOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetValueofcOutputDTO : GetValueofcOutputDTOBase { }

    [FunctionOutput]
    public class GetValueofcOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }




}
