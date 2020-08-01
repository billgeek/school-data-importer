; ################################################################
; appends \ to the path if missing
; example: !insertmacro GetCleanDir "c:\blabla"
; Pop $0 => "c:\blabla\"
!macro GetCleanDir INPUTDIR
  ; ATTENTION: USE ON YOUR OWN RISK!
  ; Please report bugs here: http://stefan.bertels.org/
  !define Index_GetCleanDir 'GetCleanDir_Line${__LINE__}'
  Push $R0
  Push $R1
  StrCpy $R0 "${INPUTDIR}"
  StrCmp $R0 "" ${Index_GetCleanDir}-finish
  StrCpy $R1 "$R0" "" -1
  StrCmp "$R1" "\" ${Index_GetCleanDir}-finish
  StrCpy $R0 "$R0\"
${Index_GetCleanDir}-finish:
  Pop $R1
  Exch $R0
  !undef Index_GetCleanDir
!macroend
 
; ################################################################
; appends \ to the path if missing and returns parent directory
; example: !insertmacro GetCleanDir "c:\blabla\subdir"
; Pop $0 => "c:\blabla\"
!macro GetCleanParentDir INPUTDIR
  ; ATTENTION: USE ON YOUR OWN RISK!
  ; Please report bugs here: http://stefan.bertels.org/
  !define Index_GetCleanParentDir 'GetCleanParentDir_Line${__LINE__}'
  Push $R0
  Push $R1
  Push $R2
  !insertmacro GetCleanDir "${INPUTDIR}"
  Pop $R0
  StrCpy $R1 "$R0"
${Index_GetCleanParentDir}-loop:
  StrCmp "$R1" "" ${Index_GetCleanParentDir}-finish
  StrCpy $R1 "$R1" -1
  StrCpy $R2 "$R1" "" -1
  StrCmp "$R2" "\" 0 ${Index_GetCleanParentDir}-loop
  StrCpy $R0 "$R1"
${Index_GetCleanParentDir}-finish:
  Pop $R2
  Pop $R1
  Exch $R0
  !undef Index_GetCleanParentDir
!macroend
 
; ################################################################
; split "c:\test" into "c:" and "\test"
; split "\\server\share\test\test" into "\\server\share" and "\test\test"
; split other patterns into "" and "PATH"
; the two parts will be pushed on the stack
; get parts with Pop $drive and Pop $folder
!macro SplitPath PATH
  ; ATTENTION: USE ON YOUR OWN RISK!
  ; Please report bugs here: http://stefan.bertels.org/
  !define Index_SplitPath 'SplitPath_${__LINE__}'
  Push $R0
  StrCpy $R0 "${PATH}" ; $R0 contains PATH
  Push $R1
  Push $R2 ; number of the first "\" of folder part
  Push $R3
  Push $R4
 
  ; check for path type (c:\test or \\server\share\test)
  StrCpy $R2 $R0 2 0
  StrCmp $R2 "\\" 0 ${Index_SplitPath}-nounc
  StrCpy $R2 3
  StrLen $R1 $R0
  StrCpy $R4 -1
${Index_SplitPath}-loop:
  IntOp $R4 $R4 + 1
  IntCmp $R4 $R1 ${Index_SplitPath}-end
  StrCpy $R3 $R0 1 $R4
  StrCmp $R3 "\" 0 ${Index_SplitPath}-loop
  IntCmp $R2 0 ${Index_SplitPath}-split
  IntOp $R2 $R2 - 1
  Goto ${Index_SplitPath}-loop
${Index_SplitPath}-split:
  StrCpy $R1 $R0 "" $R4
  StrCpy $R0 $R0 $R4
  Goto ${Index_SplitPath}-finish
${Index_SplitPath}-end:
  StrCpy $R1 ""
  Goto ${Index_SplitPath}-finish
 
${Index_SplitPath}-nounc:
  StrCpy $R2 $R0 1 1
  StrCmp $R2 ":" 0 ${Index_SplitPath}-fallback
  StrCpy $R1 $R0 "" 2
  StrCpy $R0 $R0 2
  Goto ${Index_SplitPath}-finish
 
${Index_SplitPath}-fallback:
  StrCpy $R1 $R0
  StrCpy $R0 ""
${Index_SplitPath}-finish:
  Pop $R4
  Pop $R3
  Pop $R2
  Exch $R1 ; folder part
  Exch
  Exch $R0 ; drive part
  !undef Index_SplitPath
!macroend
 
; ################################################################
; mkdir DIRECTORY and return the part which already existed (BASEDIR)
!macro MakeDirBase DIRECTORY
  ; ATTENTION: USE ON YOUR OWN RISK!
  ; Please report bugs here: http://stefan.bertels.org/
  !define Index_MakeDirBase 'MakeDirBase_${__LINE__}'
  Push $R0
  StrCpy $R0 "${DIRECTORY}" ; $R0 contains DIRECTORY
  Push $R1 ; $R1 is tmp path (increasing)
  Push $R2 ; number of "\" to ignore (1 for c:\, 4 for \\server\share\)
  Push $R3 ; pos
  Push $R4 ; len
  Push $R5 ; tmp char
  Push $R6 ; BASEDIR (return value)
  ; save outdir
  Push $OUTDIR
 
  !insertmacro GetCleanDir $R0
  Pop $R0
  !insertmacro SplitPath $R0
  Pop $R1 ; drive
  Pop $R2 ; folder
  StrCmp $R1 "" ${Index_MakeDirBase}-fallback ; ohne Laufwerk/UNC?
  StrCpy $R3 $R2 1 0
  StrCmp $R3 "\" 0 ${Index_MakeDirBase}-fallback ; relativ?
 
  StrCpy $R3 0
  StrCpy $R1 "$R1\"
  StrCpy $R6 $R1
  StrLen $R4 $R2
${Index_MakeDirBase}-loop:
  IntOp $R3 $R3 + 1
  IntCmp $R4 $R3 ${Index_MakeDirBase}-exists ; end of R0
  StrCpy $R5 $R2 1 $R3 ; get next char
  StrCpy $R1 "$R1$R5" ; add another char
  StrCmp $R5 "\" 0 ${Index_MakeDirBase}-loop
  ; debug  MessageBox MB_OK "check $R1"
  IfFileExists "$R1*.*" 0 ${Index_MakeDirBase}-mkdir
  StrCpy $R6 $R1
  Goto ${Index_MakeDirBase}-loop
${Index_MakeDirBase}-mkdir:
  ; debug  MessageBox MB_OK "mkdir $R0"
  SetOutPath $R0
  Goto ${Index_MakeDirBase}-finish
${Index_MakeDirBase}-exists:
  ;  debug MessageBox MB_OK "exists $R0"
  StrCpy $R6 $R0
  Goto ${Index_MakeDirBase}-finish
 
${Index_MakeDirBase}-fallback:
  ; debug MessageBox MB_OK "fallback"
  SetOutPath $R0
  !insertmacro GetCleanParentDir $R0
  Pop $R6
 
${Index_MakeDirBase}-finish:
  ; restore outdir
  Pop $OUTDIR
 
  StrCpy $R0 $R6
  Pop $R6
  Pop $R5
  Pop $R4
  Pop $R3
  Pop $R2
  Pop $R1
  Exch $R0
  !undef Index_MakeDirBase
!macroend
 
; ################################################################
; rmdir DIRECTORY and all parents (if empty) up to BASEDIR (leave BASEDIR there)
!macro RemoveDirBase DIRECTORY BASEDIR
  ; ATTENTION: USE ON YOUR OWN RISK!
  ; Please report bugs here: http://stefan.bertels.org/
  !define Index_RemoveDirBase 'RemoveDirBase_${__LINE__}'
  Push ${DIRECTORY}
  Push ${BASEDIR}
  Push $R1
  Exch
  Pop $R1 ; $R1 contains BASEDIR
  Push $R0
  Exch 2
  Pop $R0 ; $0R contains DIRECTORY
  ; stack order: TOP => old $R1 => old $R0
  Push $R2
  Push $R3
  Push $OUTDIR
 
  !insertmacro GetCleanDir $R0
  Pop $R0
 
  ; basedir vorhanden?
  StrCmp $R1 "" ${Index_RemoveDirBase}-fallback
 
  ; basedir teil von DIRECTORY?
  StrLen $R2 $R1
  StrCpy $R3 $R0 $R2
  StrCmp $R1 $R3 0 ${Index_RemoveDirBase}-fallback ; is basedir the beginning of directory?
 
  ; au√üerdem muss BASEDIR mindestens (drive) enthalten
  !insertmacro SplitPath $R1
  Pop $R2  ; drive part
  Pop $R3  ; folder part
  StrCmp $R2 "" ${Index_RemoveDirBase}-fallback
  ; basedir is ok
 
${Index_RemoveDirBase}-loop:
  StrCmp $R0 $R1 ${Index_RemoveDirBase}-finish
  !insertmacro GetCleanParentDir $R0
  Pop $R2
  StrCmp $R2 $R0 ${Index_RemoveDirBase}-finish ; zur Sicherheit (kann eigentlich nicht auftreten)
  SetOutPath $R2
  RmDir $R0
  StrCpy $R0 $R2
  goto ${Index_RemoveDirBase}-loop
 
${Index_RemoveDirBase}-fallback:
  !insertmacro GetCleanParentDir $R0
  Pop $R1
  SetOutPath $R1
  RmDir $R0
 
${Index_RemoveDirBase}-finish:
  Pop $OUTDIR
  Pop $R3
  POp $R2
  Pop $R1
  Pop $R0
  !undef Index_RemoveDirBase
!macroend

############################################################################################
#      NSIS Installation Script created by NSIS Quick Setup Script Generator v1.09.18
#               Entirely Edited with NullSoft Scriptable Installation System                
#              by Vlasis K. Barkas aka Red Wine red_wine@freemail.gr Sep 2006               
############################################################################################

!define APP_NAME "School Data Importer"
!define COMP_NAME "QSoft"
!define WEB_SITE "http://www.quaintsoft.co.za/"
!define VERSION "01.00.00.02"
!define COPYRIGHT "Author  © 2020"
!define DESCRIPTION "Export utility for school databases"
!define INSTALLER_NAME "D:\Development\git\school-data-importer\SchoolDataImporter.Setup\setup.exe"
!define MAIN_APP_EXE "SchoolDataImporter.exe"
!define INSTALL_TYPE "SetShellVarContext current"
!define REG_ROOT "HKCU"
!define REG_APP_PATH "Software\Microsoft\Windows\CurrentVersion\App Paths\${MAIN_APP_EXE}"
!define UNINSTALL_PATH "Software\Microsoft\Windows\CurrentVersion\Uninstall\${APP_NAME}"

######################################################################

VIProductVersion  "${VERSION}"
VIAddVersionKey "ProductName"  "${APP_NAME}"
VIAddVersionKey "CompanyName"  "${COMP_NAME}"
VIAddVersionKey "LegalCopyright"  "${COPYRIGHT}"
VIAddVersionKey "FileDescription"  "${DESCRIPTION}"
VIAddVersionKey "FileVersion"  "${VERSION}"

######################################################################

SetCompressor ZLIB
Name "${APP_NAME}"
Caption "${APP_NAME}"
OutFile "${INSTALLER_NAME}"
BrandingText "${APP_NAME}"
XPStyle on
InstallDirRegKey "${REG_ROOT}" "${REG_APP_PATH}" ""
InstallDir "$PROGRAMFILES\School Data Importer"

######################################################################

!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_UNABORTWARNING

!insertmacro MUI_PAGE_WELCOME

!ifdef LICENSE_TXT
!insertmacro MUI_PAGE_LICENSE "${LICENSE_TXT}"
!endif

!insertmacro MUI_PAGE_DIRECTORY

!ifdef REG_START_MENU
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "School Data Importer"
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "${REG_ROOT}"
!define MUI_STARTMENUPAGE_REGISTRY_KEY "${UNINSTALL_PATH}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "${REG_START_MENU}"
!insertmacro MUI_PAGE_STARTMENU Application $SM_Folder
!endif

!insertmacro MUI_PAGE_INSTFILES

!define MUI_FINISHPAGE_RUN "$INSTDIR\${MAIN_APP_EXE}"
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_CONFIRM

!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_UNPAGE_FINISH

!insertmacro MUI_LANGUAGE "English"

######################################################################
Section -MainProgram
${INSTALL_TYPE}
SetOverwrite ifnewer
SetOutPath "$INSTDIR"
!insertmacro MakeDirBase $INSTDIR\logs
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\DefaultQueries.json"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\DeviceId.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\EPPlus.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Meziantou.Framework.Win32.CredentialManager.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Microsoft.Bcl.AsyncInterfaces.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Microsoft.Extensions.DependencyInjection.Abstractions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Microsoft.Extensions.DependencyInjection.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Microsoft.Win32.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\netstandard.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Newtonsoft.Json.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\SchoolDataImporter.exe"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\SchoolDataImporter.exe.config"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Serilog.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Serilog.Filters.Expressions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Serilog.Settings.AppSettings.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Serilog.Sinks.File.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\SerilogMetrics.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\Superpower.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.AppContext.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Collections.Concurrent.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Collections.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Collections.NonGeneric.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Collections.Specialized.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ComponentModel.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ComponentModel.EventBasedAsync.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ComponentModel.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ComponentModel.TypeConverter.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Console.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Data.Common.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.Contracts.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.Debug.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.FileVersionInfo.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.Process.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.StackTrace.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.TextWriterTraceListener.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.Tools.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.TraceSource.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Diagnostics.Tracing.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Drawing.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Dynamic.Runtime.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Globalization.Calendars.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Globalization.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Globalization.Extensions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.Compression.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.Compression.ZipFile.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.FileSystem.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.FileSystem.DriveInfo.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.FileSystem.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.FileSystem.Watcher.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.IsolatedStorage.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.MemoryMappedFiles.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.Pipes.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.IO.UnmanagedMemoryStream.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Linq.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Linq.Expressions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Linq.Parallel.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Linq.Queryable.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Http.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.NameResolution.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.NetworkInformation.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Ping.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Requests.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Security.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.Sockets.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.WebHeaderCollection.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.WebSockets.Client.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Net.WebSockets.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ObjectModel.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Reflection.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Reflection.Extensions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Reflection.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Resources.Reader.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Resources.ResourceManager.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Resources.Writer.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.CompilerServices.Unsafe.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.CompilerServices.VisualC.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Extensions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Handles.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.InteropServices.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.InteropServices.RuntimeInformation.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Numerics.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Serialization.Formatters.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Serialization.Json.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Serialization.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Runtime.Serialization.Xml.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Claims.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Cryptography.Algorithms.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Cryptography.Csp.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Cryptography.Encoding.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Cryptography.Primitives.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Cryptography.X509Certificates.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.Principal.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Security.SecureString.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Text.Encoding.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Text.Encoding.Extensions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Text.RegularExpressions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Overlapped.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Tasks.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Tasks.Extensions.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Tasks.Parallel.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Thread.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.ThreadPool.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Threading.Timer.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.ValueTuple.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.ReaderWriter.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.XDocument.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.XmlDocument.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.XmlSerializer.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.XPath.dll"
File "D:\Development\git\school-data-importer\SchoolDataImporter\bin\Release\System.Xml.XPath.XDocument.dll"
SectionEnd

######################################################################

Section -Icons_Reg
SetOutPath "$INSTDIR"
WriteUninstaller "$INSTDIR\uninstall.exe"

!ifdef REG_START_MENU
!insertmacro MUI_STARTMENU_WRITE_BEGIN Application
CreateDirectory "$SMPROGRAMS\$SM_Folder"
CreateShortCut "$SMPROGRAMS\$SM_Folder\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$DESKTOP\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$SMPROGRAMS\$SM_Folder\Uninstall ${APP_NAME}.lnk" "$INSTDIR\uninstall.exe"

!ifdef WEB_SITE
WriteIniStr "$INSTDIR\${APP_NAME} website.url" "InternetShortcut" "URL" "${WEB_SITE}"
CreateShortCut "$SMPROGRAMS\$SM_Folder\${APP_NAME} Website.lnk" "$INSTDIR\${APP_NAME} website.url"
!endif
!insertmacro MUI_STARTMENU_WRITE_END
!endif

!ifndef REG_START_MENU
CreateDirectory "$SMPROGRAMS\School Data Importer"
CreateShortCut "$SMPROGRAMS\School Data Importer\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$DESKTOP\${APP_NAME}.lnk" "$INSTDIR\${MAIN_APP_EXE}"
CreateShortCut "$SMPROGRAMS\School Data Importer\Uninstall ${APP_NAME}.lnk" "$INSTDIR\uninstall.exe"

!ifdef WEB_SITE
WriteIniStr "$INSTDIR\${APP_NAME} website.url" "InternetShortcut" "URL" "${WEB_SITE}"
CreateShortCut "$SMPROGRAMS\School Data Importer\${APP_NAME} Website.lnk" "$INSTDIR\${APP_NAME} website.url"
!endif
!endif

WriteRegStr ${REG_ROOT} "${REG_APP_PATH}" "" "$INSTDIR\${MAIN_APP_EXE}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayName" "${APP_NAME}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "UninstallString" "$INSTDIR\uninstall.exe"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayIcon" "$INSTDIR\${MAIN_APP_EXE}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "DisplayVersion" "${VERSION}"
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "Publisher" "${COMP_NAME}"

!ifdef WEB_SITE
WriteRegStr ${REG_ROOT} "${UNINSTALL_PATH}"  "URLInfoAbout" "${WEB_SITE}"
!endif
SectionEnd

######################################################################

Section Uninstall
${INSTALL_TYPE}
Delete "$INSTDIR\DefaultQueries.json"
Delete "$INSTDIR\DeviceId.dll"
Delete "$INSTDIR\EPPlus.dll"
Delete "$INSTDIR\Meziantou.Framework.Win32.CredentialManager.dll"
Delete "$INSTDIR\Microsoft.Bcl.AsyncInterfaces.dll"
Delete "$INSTDIR\Microsoft.Extensions.DependencyInjection.Abstractions.dll"
Delete "$INSTDIR\Microsoft.Extensions.DependencyInjection.dll"
Delete "$INSTDIR\Microsoft.Win32.Primitives.dll"
Delete "$INSTDIR\netstandard.dll"
Delete "$INSTDIR\Newtonsoft.Json.dll"
Delete "$INSTDIR\SchoolDataImporter.exe"
Delete "$INSTDIR\SchoolDataImporter.exe.config"
Delete "$INSTDIR\Serilog.dll"
Delete "$INSTDIR\Serilog.Filters.Expressions.dll"
Delete "$INSTDIR\Serilog.Settings.AppSettings.dll"
Delete "$INSTDIR\Serilog.Sinks.File.dll"
Delete "$INSTDIR\SerilogMetrics.dll"
Delete "$INSTDIR\Superpower.dll"
Delete "$INSTDIR\System.AppContext.dll"
Delete "$INSTDIR\System.Collections.Concurrent.dll"
Delete "$INSTDIR\System.Collections.dll"
Delete "$INSTDIR\System.Collections.NonGeneric.dll"
Delete "$INSTDIR\System.Collections.Specialized.dll"
Delete "$INSTDIR\System.ComponentModel.dll"
Delete "$INSTDIR\System.ComponentModel.EventBasedAsync.dll"
Delete "$INSTDIR\System.ComponentModel.Primitives.dll"
Delete "$INSTDIR\System.ComponentModel.TypeConverter.dll"
Delete "$INSTDIR\System.Console.dll"
Delete "$INSTDIR\System.Data.Common.dll"
Delete "$INSTDIR\System.Diagnostics.Contracts.dll"
Delete "$INSTDIR\System.Diagnostics.Debug.dll"
Delete "$INSTDIR\System.Diagnostics.FileVersionInfo.dll"
Delete "$INSTDIR\System.Diagnostics.Process.dll"
Delete "$INSTDIR\System.Diagnostics.StackTrace.dll"
Delete "$INSTDIR\System.Diagnostics.TextWriterTraceListener.dll"
Delete "$INSTDIR\System.Diagnostics.Tools.dll"
Delete "$INSTDIR\System.Diagnostics.TraceSource.dll"
Delete "$INSTDIR\System.Diagnostics.Tracing.dll"
Delete "$INSTDIR\System.Drawing.Primitives.dll"
Delete "$INSTDIR\System.Dynamic.Runtime.dll"
Delete "$INSTDIR\System.Globalization.Calendars.dll"
Delete "$INSTDIR\System.Globalization.dll"
Delete "$INSTDIR\System.Globalization.Extensions.dll"
Delete "$INSTDIR\System.IO.Compression.dll"
Delete "$INSTDIR\System.IO.Compression.ZipFile.dll"
Delete "$INSTDIR\System.IO.dll"
Delete "$INSTDIR\System.IO.FileSystem.dll"
Delete "$INSTDIR\System.IO.FileSystem.DriveInfo.dll"
Delete "$INSTDIR\System.IO.FileSystem.Primitives.dll"
Delete "$INSTDIR\System.IO.FileSystem.Watcher.dll"
Delete "$INSTDIR\System.IO.IsolatedStorage.dll"
Delete "$INSTDIR\System.IO.MemoryMappedFiles.dll"
Delete "$INSTDIR\System.IO.Pipes.dll"
Delete "$INSTDIR\System.IO.UnmanagedMemoryStream.dll"
Delete "$INSTDIR\System.Linq.dll"
Delete "$INSTDIR\System.Linq.Expressions.dll"
Delete "$INSTDIR\System.Linq.Parallel.dll"
Delete "$INSTDIR\System.Linq.Queryable.dll"
Delete "$INSTDIR\System.Net.Http.dll"
Delete "$INSTDIR\System.Net.NameResolution.dll"
Delete "$INSTDIR\System.Net.NetworkInformation.dll"
Delete "$INSTDIR\System.Net.Ping.dll"
Delete "$INSTDIR\System.Net.Primitives.dll"
Delete "$INSTDIR\System.Net.Requests.dll"
Delete "$INSTDIR\System.Net.Security.dll"
Delete "$INSTDIR\System.Net.Sockets.dll"
Delete "$INSTDIR\System.Net.WebHeaderCollection.dll"
Delete "$INSTDIR\System.Net.WebSockets.Client.dll"
Delete "$INSTDIR\System.Net.WebSockets.dll"
Delete "$INSTDIR\System.ObjectModel.dll"
Delete "$INSTDIR\System.Reflection.dll"
Delete "$INSTDIR\System.Reflection.Extensions.dll"
Delete "$INSTDIR\System.Reflection.Primitives.dll"
Delete "$INSTDIR\System.Resources.Reader.dll"
Delete "$INSTDIR\System.Resources.ResourceManager.dll"
Delete "$INSTDIR\System.Resources.Writer.dll"
Delete "$INSTDIR\System.Runtime.CompilerServices.Unsafe.dll"
Delete "$INSTDIR\System.Runtime.CompilerServices.VisualC.dll"
Delete "$INSTDIR\System.Runtime.dll"
Delete "$INSTDIR\System.Runtime.Extensions.dll"
Delete "$INSTDIR\System.Runtime.Handles.dll"
Delete "$INSTDIR\System.Runtime.InteropServices.dll"
Delete "$INSTDIR\System.Runtime.InteropServices.RuntimeInformation.dll"
Delete "$INSTDIR\System.Runtime.Numerics.dll"
Delete "$INSTDIR\System.Runtime.Serialization.Formatters.dll"
Delete "$INSTDIR\System.Runtime.Serialization.Json.dll"
Delete "$INSTDIR\System.Runtime.Serialization.Primitives.dll"
Delete "$INSTDIR\System.Runtime.Serialization.Xml.dll"
Delete "$INSTDIR\System.Security.Claims.dll"
Delete "$INSTDIR\System.Security.Cryptography.Algorithms.dll"
Delete "$INSTDIR\System.Security.Cryptography.Csp.dll"
Delete "$INSTDIR\System.Security.Cryptography.Encoding.dll"
Delete "$INSTDIR\System.Security.Cryptography.Primitives.dll"
Delete "$INSTDIR\System.Security.Cryptography.X509Certificates.dll"
Delete "$INSTDIR\System.Security.Principal.dll"
Delete "$INSTDIR\System.Security.SecureString.dll"
Delete "$INSTDIR\System.Text.Encoding.dll"
Delete "$INSTDIR\System.Text.Encoding.Extensions.dll"
Delete "$INSTDIR\System.Text.RegularExpressions.dll"
Delete "$INSTDIR\System.Threading.dll"
Delete "$INSTDIR\System.Threading.Overlapped.dll"
Delete "$INSTDIR\System.Threading.Tasks.dll"
Delete "$INSTDIR\System.Threading.Tasks.Extensions.dll"
Delete "$INSTDIR\System.Threading.Tasks.Parallel.dll"
Delete "$INSTDIR\System.Threading.Thread.dll"
Delete "$INSTDIR\System.Threading.ThreadPool.dll"
Delete "$INSTDIR\System.Threading.Timer.dll"
Delete "$INSTDIR\System.ValueTuple.dll"
Delete "$INSTDIR\System.Xml.ReaderWriter.dll"
Delete "$INSTDIR\System.Xml.XDocument.dll"
Delete "$INSTDIR\System.Xml.XmlDocument.dll"
Delete "$INSTDIR\System.Xml.XmlSerializer.dll"
Delete "$INSTDIR\System.Xml.XPath.dll"
Delete "$INSTDIR\System.Xml.XPath.XDocument.dll"
Delete "$INSTDIR\uninstall.exe"
!ifdef WEB_SITE
Delete "$INSTDIR\${APP_NAME} website.url"
!endif

RmDir "$INSTDIR"

!ifdef REG_START_MENU
!insertmacro MUI_STARTMENU_GETFOLDER "Application" $SM_Folder
Delete "$SMPROGRAMS\$SM_Folder\${APP_NAME}.lnk"
Delete "$SMPROGRAMS\$SM_Folder\Uninstall ${APP_NAME}.lnk"
!ifdef WEB_SITE
Delete "$SMPROGRAMS\$SM_Folder\${APP_NAME} Website.lnk"
!endif
Delete "$DESKTOP\${APP_NAME}.lnk"

RmDir "$SMPROGRAMS\$SM_Folder"
!endif

!ifndef REG_START_MENU
Delete "$SMPROGRAMS\School Data Importer\${APP_NAME}.lnk"
Delete "$SMPROGRAMS\School Data Importer\Uninstall ${APP_NAME}.lnk"
!ifdef WEB_SITE
Delete "$SMPROGRAMS\School Data Importer\${APP_NAME} Website.lnk"
!endif
Delete "$DESKTOP\${APP_NAME}.lnk"

RmDir "$SMPROGRAMS\School Data Importer"
!endif

DeleteRegKey ${REG_ROOT} "${REG_APP_PATH}"
DeleteRegKey ${REG_ROOT} "${UNINSTALL_PATH}"
SectionEnd

######################################################################

