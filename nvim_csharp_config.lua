; Minimal C# configuration for Neovim
; Add this to your init.lua or separate lua file

-- C# LSP setup
local lspconfig = require('lspconfig')

-- Using csharp-ls (official, faster)
lspconfig.csharp_ls.setup{
  on_attach = on_attach,
  capabilities = capabilities,
}

-- Alternative: OmniSharp (if you prefer)
-- lspconfig.omnisharp.setup{
--   cmd = { "omnisharp", "--languageserver", "--hostPID", tostring(vim.fn.getpid()) },
--   on_attach = on_attach,
--   capabilities = capabilities,
-- }

-- Formatting with CSharpier
local conform = require('conform')
conform.setup({
  formatters_by_ft = {
    cs = { "csharpier" },
  },
  format_on_save = true,
})

-- Keymaps útiles para C#
vim.keymap.set('n', '<leader>db', ':dotnet build<CR>', { desc = 'Dotnet Build' })
vim.keymap.set('n', '<leader>dr', ':dotnet run<CR>', { desc = 'Dotnet Run' })
vim.keymap.set('n', '<leader>dt', ':dotnet test<CR>', { desc = 'Dotnet Test' })
