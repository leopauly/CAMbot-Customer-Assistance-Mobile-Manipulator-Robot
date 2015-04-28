#!/bin/sh -x

if [ -n "$DESTDIR" ] ; then
    case $DESTDIR in
        /*) # ok
            ;;
        *)
            /bin/echo "DESTDIR argument must be absolute... "
            /bin/echo "otherwise python's distutils will bork things."
            exit 1
    esac
    DESTDIR_ARG="--root=$DESTDIR"
fi

cd "/home/haha/catkin_ws/src/rosserial/rosserial_xbee"

# todo --install-layout=deb per platform
# Note that PYTHONPATH is pulled from the environment to support installing
# into one location when some dependencies were installed in another
# location, #123.
/usr/bin/env \
    PYTHONPATH="/home/haha/catkin_ws/install/lib/python2.7/dist-packages:/home/haha/catkin_ws/build/lib/python2.7/dist-packages:$PYTHONPATH" \
    CATKIN_BINARY_DIR="/home/haha/catkin_ws/build" \
    "/usr/bin/python" \
    "/home/haha/catkin_ws/src/rosserial/rosserial_xbee/setup.py" \
    build --build-base "/home/haha/catkin_ws/build/rosserial/rosserial_xbee" \
    install \
    $DESTDIR_ARG \
    --install-layout=deb --prefix="/home/haha/catkin_ws/install" --install-scripts="/home/haha/catkin_ws/install/bin"
