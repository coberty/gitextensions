using System.Text.RegularExpressions;
        /// Diff part of patch is printed verbatim, everything else (header, warnings, ...) is printed in git encoding (GitModule.SystemEncoding) 
                    input = GitModule.ReEncodeFileNameFromLossless(input);
                        //header lines are encoded in GitModule.SystemEncoding
                        input = GitModule.ReEncodeStringFromLossless(input, GitModule.SystemEncoding);
                    input = GitModule.UnquoteFileName(input);
                    Match regexMatch = Regex.Match(input, "[-]{3}[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}");
                    input = GitModule.UnquoteFileName(input);
                    Match regexMatch = Regex.Match(input, "[+]{3}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");
                    input = GitModule.ReEncodeStringFromLossless(input, FilesContentEncoding);
                    input = GitModule.ReEncodeStringFromLossless(input, GitModule.SystemEncoding);                    
                                      "[ ][\\\"]{0,1}[aiwco12]/(.*)[\\\"]{0,1}[ ][\\\"]{0,1}[biwco12]/(.*)[\\\"]{0,1}");