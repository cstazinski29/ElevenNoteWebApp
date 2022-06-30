using ElevenNoteWebApp.Server.Data;
using ElevenNoteWebApp.Shared.Models.Note;

namespace ElevenNoteWebApp.Server.Services.Note
{
    public class NoteService : INoteService
    {
        private readonly ApplicationDbContext _context;
        public NoteService(ApplicationDbContext context)
        {
            _context = context;
        }

         public Task<bool> CreateNoteAsync(NoteCreate model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNoteAsync(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteNoteAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NoteListItem>> GetAllNotesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NoteDetail> GetNoteByIdAsync(int noteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateNoteAsync(NoteEdit model)
        {
            throw new NotImplementedException();
        }

        private string _userId;
        public void SetUserId(string userId) => _userId = userId;
    }
}
