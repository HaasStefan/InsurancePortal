
public interface IContractService
{
    Contract createContract(Contract contract);
    Contract updateContract(Contract contract);
    Contract getContract(Guid id);
    Contract[] getContracts();
}