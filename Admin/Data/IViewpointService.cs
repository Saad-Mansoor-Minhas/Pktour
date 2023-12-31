﻿using ClassLibraryEntity;
namespace Admin.Data
{
	public interface IViewpointService
	{
		Task<List<EntViewpoints>> GetViewpoints();
		Task<List<EntViewpoints>> GetCityViewpoints(int id);
		Task SaveViewpoint(EntViewpoints viewpoint);
		Task DeleteViewpoint(int id);
		Task UpdateViewpoint(EntViewpoints viewpoint);
	}
}
