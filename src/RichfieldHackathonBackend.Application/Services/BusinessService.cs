using RichfieldHackathonBackend.Application.Dtos.Business;
using RichfieldHackathonBackend.Domain.Interfaces;

public class BusinessService
{
    private readonly IBusinessRepo _businessRepo;
    private readonly IOpportunityRepo _opportunityRepo;
    private readonly BusinessMappers _mapper;

    public BusinessService(IBusinessRepo businessRepo, IOpportunityRepo opportunityRepo, BusinessMappers mapper)
    {
        _businessRepo = businessRepo;
        _opportunityRepo = opportunityRepo;
        _mapper = mapper;
    }
    public async Task<GetBusinessDto> PostBusiness(PostBusinessDto dto, Guid userId)
    {
        var entity = _mapper.MapToEntityBusiness(dto);
        var res = await _businessRepo.PostBusinessAsync(entity, userId);
        return _mapper.MapToGetBusiness(res);
    }
    public async Task<GetBusinessDto> GetBusiness(Guid businessId)
    {

        var entity = await _businessRepo.GetBusinessAsync(businessId);
        var res = _mapper.MapToGetBusiness(entity);
        return res;

    }
    public async Task<GetOpportunityDto> PostOpportunity(PostOpportunityDto dto, Guid businessId)
    {
        var entity = _mapper.MapToEntityOpportunity(dto);
        var res = await _opportunityRepo.PostOpportunityAsync(entity, businessId);
        return _mapper.MapToGetOpportunity(res);
    }
    public async Task<GetOpportunityDto> GetOpportunity(Guid businessId)
    {

        var entity = await _opportunityRepo.GetOpportunityAsync(businessId);
        var res = _mapper.MapToGetOpportunity(entity);
        return res;

    }
    public async Task<ICollection<GetOpportunityDto>> GetOpportunityAll()
    {

        var oportunities = await _opportunityRepo.GetAllOpportunitiesAsync();
        var res = oportunities.Select(x => _mapper.MapToGetOpportunity(x)).ToList();
        return res;
    }
    public async Task<ICollection<GetBusinessDto>> GetBusinessAll()
    {

        var businesses = await _businessRepo.GetAllBusinessAsync();
        var res = businesses.Select(x => _mapper.MapToGetBusiness(x)).ToList();
        return res;
    }
}