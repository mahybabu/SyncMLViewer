﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncMLViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("taken from official documentation: http://openmobilealliance.org/release/Common/V" +
            "1_2_2-20090724-A/OMA-TS-SyncML-RepPro-V1_2_2-20090724-A.pdf\r\nuse Ctrl + F to use" +
            " search to find a particular status code.\r\n\r\n\r\n--Informational (1xx)\r\n\r\n101\r\nIn " +
            "progress. The specified SyncML command is being carried out, but has not yet com" +
            "pleted.\r\n\r\n\r\n\r\n--Successful (2xx)\r\n\r\n200\r\nOK. The SyncML command completed succe" +
            "ssfully.\r\n\r\n201\r\nItem added. The requested item was added.\r\n\r\n202\r\nAccepted for " +
            "processing. The request to either run a remote execution of an application or to" +
            " alert a user or application was successfully performed.\r\n\r\n203\r\nNon-authoritati" +
            "ve response. The request is being responded to by an entity other than the one t" +
            "argeted. The response is only to be returned when the request would have been re" +
            "sulted in a 200 response code from the authoritative target.\r\n\r\n204\r\nNo content." +
            " The request was successfully completed but no data is being returned. The respo" +
            "nse code is also returned in response to a Get when the target has no content.\r\n" +
            "\r\n205\r\nReset content. The source SHOULD update their content. The originator of " +
            "the request is being told that their content SHOULD be synchronized to get an up" +
            " to date version.\r\n\r\n206\r\nPartial content. The response indicates that only part" +
            " of the command was completed. If the remainder of the command can be completed " +
            "later, then when completed another appropriate completion request status code SH" +
            "OULD be created.\r\n\r\n207\r\nConflict resolved with merge. The response indicates th" +
            "at the request created a conflict; which was resolved with a merge of the client" +
            " and server instances of the data. The response includes both the Target and Sou" +
            "rce URLs in the Item of the Status. In addition, a Replace command is returned w" +
            "ith the merged data.\r\n\r\n208\r\nConflict resolved with client’s command \"winning\". " +
            "The response indicates that there was an update conflict; which was resolved by " +
            "the client command winning. \r\n\r\n209\r\nConflict resolved with duplicate. The respo" +
            "nse indicates that the request created an update conflict; which was resolved wi" +
            "th a duplication of the client’s data being created in the server database. The " +
            "response includes both the target URI of the duplicate in the Item of the Status" +
            ". In addition, in the case of a two-way synchronization, an Add command is retur" +
            "ned with the duplicate data definition.\r\n\r\n210\r\nDelete without archive. The resp" +
            "onse indicates that the requested data was successfully deleted, but that it was" +
            " not archived prior to deletion because this OPTIONAL feature was not supported " +
            "by the implementation.\r\n\r\n211\r\nItem not deleted. The requested item was not foun" +
            "d. It could have been previously deleted.\r\n\r\n212\r\nAuthentication accepted. No fu" +
            "rther authentication is needed for the remainder of the synchronization session." +
            " This response code can only be used in response to a request in which the crede" +
            "ntials were provided.\r\n\r\n213\r\nChunked item accepted and buffered.\r\n\r\n214\r\nOperat" +
            "ion cancelled. The SyncML command completed successfully, but no more commands w" +
            "ill be processed within the session.\r\n\r\n215\r\nNot executed. A command was not exe" +
            "cuted, as a result of user interaction and user chose not to accept the choice.\r" +
            "\n\r\n216\r\nAtomic roll back OK. A command was inside Atomic element and Atomic fail" +
            "ed. This command was rolled back successfully.\r\n\r\n\r\n\r\n--Redirection (3xx)\r\n\r\n300" +
            "\r\nMultiple choices. The requested target is one of a number of multiple alternat" +
            "ives requested target. The alternative SHOULD also be returned in the Item eleme" +
            "nt type in the Status.\r\n\r\n301\r\nMoved permanently. The requested target has a new" +
            " URI. The new URI SHOULD also be returned in the Item element type in the Status" +
            ".\r\n\r\n302\r\nFound. The requested target has temporarily moved to a different URI. " +
            "The original URI SHOULD continue to be used. The URI of the temporary location S" +
            "HOULD also be returned in the Item element type in the Status. The requestor SHO" +
            "ULD confirm the identity and authority of the temporary URI to act on behalf of " +
            "the original target URI.\r\n\r\n303\r\nSee other. The requested target can be found at" +
            " another URI. The other URI SHOULD be returned in the Item element type in the S" +
            "tatus.\r\n\r\n304\r\nNot modified. The requested SyncML command was not executed on th" +
            "e target. This is an additional response that can be added to any of the other R" +
            "edirection response codes.\r\n\r\n305\r\nUse proxy. The requested target MUST be acces" +
            "sed through the specified proxy URI. The proxy URI SHOULD also be returned in th" +
            "e Item element type in the Status.\r\n\r\n\r\n\r\n--Originator Exceptions (4xx)\r\n\r\n400\r\n" +
            "Bad request. The requested command could not be performed because of malformed s" +
            "yntax in the command. The malformed command MAY also be returned in the Item ele" +
            "ment type in the Status.\r\n\r\n401\r\nInvalid credentials. The requested command fail" +
            "ed because the requestor MUST provide proper authentication. If the property typ" +
            "e of authentication was presented in the original request, then the response cod" +
            "e indicates that the requested command has been refused for those credentials.\r\n" +
            "\r\n402\r\nPaymentneeded. The requested command failed because proper payment isneed" +
            "ed. This version of SyncML does not standardize the payment mechanism.\r\n\r\n403\r\nF" +
            "orbidden. The requested command failed, but the recipient understood the request" +
            "ed command. Authentication will not help and the request SHOULD NOT be repeated." +
            " If the recipient wishes to make public why the request was denied, then a descr" +
            "iption MAY be specified in the Item element type in the Status. If the recipient" +
            " does not wish to make public why the request was denied then the response code " +
            "404 MAY be used instead.\r\n\r\n404\r\nNot found. The requested target was not found. " +
            "No indication is given as to whether this is a temporary or permanent condition." +
            " The response code 410 SHOULD be used when the condition is permanent and the re" +
            "cipient wishes to make this fact public. This response code is also used when th" +
            "e recipient does not want to make public the reason for why a requested command " +
            "is not allowed or when no other response code is appropriate.\r\n\r\n405\r\nCommand no" +
            "t allowed. The requested command is not allowed on the target. The recipient SHO" +
            "ULD return the allowed command for the target in the Item element type in the St" +
            "atus.\r\n\r\n406\r\nOptional feature not supported. The requested command failed becau" +
            "se an OPTIONAL feature in the request was not supported. The unsupported feature" +
            " SHOULD be specified by the Item element type in the Status.\r\n\r\n407\r\nMissing cre" +
            "dentials. This response code is similar to 401 except that the response code ind" +
            "icates that the originator MUST first authenticate with the recipient. The recip" +
            "ient SHOULD also return the suitable challenge in the Chal element type in the S" +
            "tatus.\r\n\r\n408\r\nRequest timeout. An expected message was not received within the " +
            "REQUIRED period of time. The request can be repeated at another time. The RespUR" +
            "I can be used to specify the URI and optionally the date/time after which the or" +
            "iginator can repeat the request. See RespURI for details. \r\n\r\n409\r\nConflict. The" +
            " requested failed because of an update conflict between the client and server ve" +
            "rsions of the data. Setting of the conflict resolution policy is outside the sco" +
            "pe of this version of SyncML. However, identification of conflict resolution per" +
            "formed, if any, is within the scope.\r\n\r\n410\r\nGone. The requested target is no lo" +
            "nger on the recipient and no forwarding URI is known.\r\n\r\n411\r\nSize REQUIRED. The" +
            " requested command MUST be accompanied by byte size or length information in the" +
            " Meta element type.\r\n\r\n412\r\nIncomplete command. The requested command failed on " +
            "the recipient because it was incomplete or incorrectly formed. The recipient SHO" +
            "ULD specify the portion of the command that was incomplete or incorrect in the I" +
            "tem element type in the Status.\r\n\r\n413\r\nRequest entity too large. The recipient " +
            "is refusing to perform the requested command because the requested item is large" +
            "r than the recipient is able or willing to process. If the condition is temporar" +
            "y, the recipient SHOULD also include a Status with the response code 418 and spe" +
            "cify a RespURI with the response URI and optionally the date/time that the comma" +
            "nd SHOULD be repeated.\r\n\r\n414\r\nURI too long. The requested command failed becaus" +
            "e the target URI is too long for what the recipient is able or willing to proces" +
            "s. This response code is seldom encountered, but is used when a recipient percei" +
            "ves that an intruder might be attempting to exploit security holes or other defe" +
            "cts in order to threaten the recipient.\r\n\r\n415\r\nUnsupported media type or format" +
            ". The unsupported content type or format SHOULD also be identified in the Item e" +
            "lement type in the Status.\r\n\r\n416\r\nRequested size too big. The request failed be" +
            "cause the specified byte size in the request was too big.\r\n\r\n417\r\nRetry later. T" +
            "he request failed at this time and the originator SHOULD retry the request later" +
            ". The recipient SHOULD specify a RespURI with the response URI and the date/time" +
            " that the command SHOULD be repeated.\r\n\r\n418\r\nAlready exists. The requested Put " +
            "or Add command failed because the target already exists.\r\n\r\n419\r\nConflict resolv" +
            "ed with server data. The response indicates that the client request created a co" +
            "nflict; which was resolved by the server command winning. The normal information" +
            " in the Status SHOULD be sufficient for the client to \"undo\" the resolution, if " +
            "it is desired.\r\n\r\n420\r\nDevice full. The response indicates that the recipient ha" +
            "s no more storage space for the remaining synchronization data. The response inc" +
            "ludes the remaining number of data that could not be returned to the originator " +
            "in the Item of the Status.\r\n\r\n421\r\nUnknown search grammar. The requested command" +
            " failed on the server because the specified search grammar was not known. The cl" +
            "ient SHOULD re-specify the search using a known search grammar. \r\n\r\n422\r\nBad CGI" +
            " Script. The requested command failed on the server because the CGI scripting in" +
            " the LocURI was incorrectly formed. The client SHOULD re-specify the portion of " +
            "the command that was incorrect in the Item element type in the Status.\r\n\r\n423\r\nS" +
            "oft-delete conflict. The requested command failed because the \"Soft Deleted\" ite" +
            "m was previously \"Hard Deleted\" on the server.\r\n\r\n424\r\nSize mismatch. The chunke" +
            "d object was received, but the size of the received object did not match the siz" +
            "e declared within the first chunk.\r\n\r\n425\r\nPermission Denied. The requested comm" +
            "and failed because the sender does not have adequate access control permissions " +
            "(ACL) on the recipient.\r\n\r\n426\r\nPartial item not accepted. Receiver of status co" +
            "de MAY resend the whole item in next package.\r\n\r\n427\r\nItem Not empty. Parent can" +
            "not be deleted since it contains children.\r\n\r\n428\r\nMove Failed\r\n\r\n\r\n\r\n--Recipien" +
            "t Exception (5xx)\r\n\r\n500\r\nCommand failed. The recipient encountered an unexpecte" +
            "d condition which prevented it from fulfilling the request\r\n\r\n501\r\nCommand not i" +
            "mplemented. The recipient does not support the command REQUIRED to fulfill the r" +
            "equest. This is the appropriate response when the recipient does not recognize t" +
            "he requested command and is not capable of supporting it for any resource.\r\n\r\n50" +
            "2\r\nBad gateway. The recipient, while acting as a gateway or proxy, received an i" +
            "nvalid response from the upstream recipient it accessed in attempting to fulfill" +
            " the request.\r\n\r\n503\r\nService unavailable. The recipient is currently unable to " +
            "handle the request due to a temporary overloading or maintenance of the recipien" +
            "t. The implication is that this is a temporary condition; which will be alleviat" +
            "ed after some delay. The recipient SHOULD specify the URI and date/time after wh" +
            "ich the originator SHOULD retry in the RespURI in the response.\r\n\r\n504\r\nGateway " +
            "timeout. The recipient, while acting as a gateway or proxy, did not receive a ti" +
            "mely response from the upstream recipient specified by the URI (e.g. HTTP, FTP, " +
            "LDAP) or some other auxiliary recipient (e.g. DNS) it needed to access in attemp" +
            "ting to complete the request.\r\n\r\n505\r\nDTD Version not supported. The recipient d" +
            "oes not support or refuses to support the specified version of SyncML DTD used i" +
            "n the request SyncML Message. The recipient MUST include the versions it does su" +
            "pport in the Item element type in the Status.\r\n\r\n506\r\nProcessing error. An appli" +
            "cation error occurred while processing the request. The originator SHOULD retry " +
            "the request. The RespURI can contain the URI and date/time after which the origi" +
            "nator can retry the request.\r\n\r\n507\r\nAtomic failed. The error caused all SyncML " +
            "commands within an Atomic element type to fail.\r\n\r\n508\r\nRefresh REQUIRED. An err" +
            "or occurred that necessitates a refresh of the current synchronization state of " +
            "the client with the server. Client is requested to initiate the session type spe" +
            "cified in the server’s ALERT (which is included in the same package as the Statu" +
            "s 508). The only valid values for this ALERT are either a slow sync (201) or a r" +
            "efresh with the server.\r\n\r\n509\r\nReserved for future use.\r\n\r\n510\r\nData store fail" +
            "ure. An error occurred while processing the request. The error is related to a f" +
            "ailure in the recipient data store.\r\n\r\n511\r\nServer failure. A severe error occur" +
            "red in the server while processing the request. The originator SHOULD NOT retry " +
            "the request.\r\n\r\n512\r\nSynchronization failed. An application error occurred durin" +
            "g the synchronization session. The originator SHOULD restart the synchronization" +
            " session from the beginning.\r\n\r\n513\r\nProtocol Version not supported. The recipie" +
            "nt does not support or refuses to support the specified version of the SyncML Sy" +
            "nchronization Protocol used in the request SyncML Message. The recipient MUST in" +
            "clude the versions it does support in the Item element type in the Status.\r\n\r\n51" +
            "4\r\nOperation cancelled. The SyncML command was not completed successfully, since" +
            " the operation was already cancelled before processing the command. The originat" +
            "or SHOULD repeat the command in the next session.\r\n\r\n516\r\nAtomic roll back faile" +
            "d. Command was inside Atomic element and Atomic failed. This command was not rol" +
            "led back successfully. Server SHOULD take action to try to recover client back i" +
            "nto original state.\r\n\r\n517\r\nAtomic response too large to fit. The response to an" +
            " atomic command was too large to fit in a single message.\r\n\r\n\r\n\r\n--Application s" +
            "pecific codes (1xxx)\r\n\r\n1000 – 1999\r\nThese status codes are application specific" +
            " status codes and the meanings of these are not defined in this specification. \r" +
            "\n\r\nIt is recommended to define status codes with the same grouping as above with" +
            "in this application specific interval but it is the application that defines the" +
            " allowed values:\r\n\r\nInformational               11xx\r\nSuccessful                " +
            "  12xx\r\nRedirection                 13xx\r\nOriginator Exceptions       14xx\r\nReci" +
            "pient Exception         15xx")]
        public string StatusCodes {
            get {
                return ((string)(this["StatusCodes"]));
            }
            set {
                this["StatusCodes"] = value;
            }
        }
    }
}
