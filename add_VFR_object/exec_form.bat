@echo off
cd ./scripts & script_form.exe %*
cd ../fspackagetool & fspackagetool.exe ../VFR_object_package/Project-add-VFR-object.xml -outputdir ../VFR_object_package
cd ../
cd ../
copy %CD%\add_VFR_object\VFR_object_package\Packages\add-VFR-object\scenery\VFR_object.bgl %CD%\VFR_object_scenery\scenery\
exit
