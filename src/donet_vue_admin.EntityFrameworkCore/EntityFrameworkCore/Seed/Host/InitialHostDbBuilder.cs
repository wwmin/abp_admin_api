namespace donet_vue_admin.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly donet_vue_adminDbContext _context;

        public InitialHostDbBuilder(donet_vue_adminDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
